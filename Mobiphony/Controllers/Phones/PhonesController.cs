﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mobiphony.Models;

namespace Mobiphony.Controllers.Phones
{
    public class PhonesController : Controller
    {
        private readonly DatabaseContext _context;

        public PhonesController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Phone()
        {
            return View("Phone");
        }

        [HttpGet]
        public IActionResult PhoneView(int id)
        {
            var result = _context.Phones
                .Include(p => p.Features)
                .Include(p => p.CameraFeatures)
                .Include(p => p.BrandNavigation)
                .Include(p => p.MatrixNavigation)
                .FirstOrDefault(p => p.Id == id);
            ViewBag.Talktime = new Random().Next(15, 28); // Generate random value from 15 to 27 hours
            return View("PhoneView", result);
        }

        [HttpGet]
        public IActionResult Phones(IEnumerable<Phone> phones)
        {
            ViewData["Features"] = _context.Features.ToList();
            ViewData["Brands"] = _context.Brands.ToList();
            if (phones.Count() == 0)
            {
                phones = _context.Phones
                    .Include(p => p.Features)
                    .Include(p => p.CameraFeatures)
                    .Include(p => p.BrandNavigation)
                    .Include(p => p.MatrixNavigation).ToList();
            }
            return View("Phones", phones);
        }

        [HttpGet]
        public IActionResult AddPhone()
        {
            ViewData["Brands"] = _context.Brands.ToList();
            ViewData["CameraFeatures"] = _context.CameraFeatures.ToList();
            ViewData["PhoneFeatures"] = _context.Features.ToList();
            ViewData["DisplayMatrices"] = _context.DisplayMatrices.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddPhone(Phone phone, uint[] selectedCameraFeatureIds, int[] selectedPhoneFeatureIds)
        {
            ViewData["Brands"] = _context.Brands.ToList();
            ViewData["CameraFeatures"] = _context.CameraFeatures.ToList();
            ViewData["PhoneFeatures"] = _context.Features.ToList();
            ViewData["DisplayMatrices"] = _context.DisplayMatrices.ToList();
            if (ModelState.IsValid)
            {
                Phone newPhone = new Phone
                {
                    Brand = phone.Brand,
                    Model = phone.Model,
                    Length = phone.Length,
                    Width = phone.Width,
                    Thickness = phone.Thickness,
                    Weight = phone.Weight,
                    Sim = phone.Sim,
                    Iprating = phone.Iprating,
                    DisplaySize = phone.DisplaySize,
                    Matrix = phone.Matrix,
                    RefreshRate = phone.RefreshRate,
                    Brightness = phone.Brightness,
                    Resolution = phone.Resolution,
                    ScreenProtection = phone.ScreenProtection,
                    Chipset = phone.Chipset,
                    Cpu = phone.Cpu,
                    Gpu = phone.Gpu,
                    Os = phone.Os,
                    WiFiSpeed = phone.WiFiSpeed,
                    BluetoothVersion = phone.BluetoothVersion,
                    Price = phone.Price,
                    PurchaseLink = phone.PurchaseLink,
                    ImgLink = phone.ImgLink,
                    Ram = phone.Ram,
                    InternalStorage = phone.InternalStorage,
                    SselfCamVideo = phone.SselfCamVideo,
                    ExpStorageLimit = phone.ExpStorageLimit,
                    Usbtype = phone.Usbtype,
                    FingerPrint = phone.FingerPrint,
                    FaceRec = phone.FaceRec,
                    BatCapacity = phone.BatCapacity,
                    BatChargingWattage = phone.BatChargingWattage,
                    MainCamPhoto = phone.MainCamPhoto,
                    MainCamVideo = phone.MainCamVideo,
                    Rating = phone.Rating
                };

                newPhone.BrandNavigation = _context.Brands.Find(phone.Brand);
                newPhone.MatrixNavigation = _context.DisplayMatrices.Find(phone.Matrix);
                foreach (var featureId in selectedPhoneFeatureIds)
                {
                    var feature = _context.Features.Find(featureId);
                    if (feature != null)
                    {
                        feature.Phones.Add(newPhone);
                        newPhone.Features.Add(feature);
                    }
                }

                foreach (var cameraFeatureId in selectedCameraFeatureIds)
                {
                    var cameraFeature = _context.CameraFeatures.Find(cameraFeatureId);
                    if (cameraFeature != null)
                    {
                        cameraFeature.Phones.Add(newPhone);
                        newPhone.CameraFeatures.Add(cameraFeature);
                    }
                }
                _context.Phones.Add(phone);

                _context.SaveChanges();

                return RedirectToAction(nameof(AddPhone));
            }

            return View(phone);
        }

        [HttpPost]
        public IActionResult Filter(int[] brandIds, int[] featureIds, double rating, int maxprice, int minprice)
        {
            ViewData["Brands"] = _context.Brands.ToList();
            ViewData["Features"] = _context.Features.ToList();
            var model = _context.Phones
                .Include(p => p.Features)
                .Include(p => p.CameraFeatures)
                .Include(p => p.BrandNavigation)
                .Include(p => p.MatrixNavigation)
                .AsQueryable();
            if (rating != 0)
            {
                model = model.Where(p => p.Rating > rating);
            }
            if (brandIds.Length != 0)
            {
                model = model.Where(p => brandIds.Contains(p.Brand));
            }
            if (maxprice != 0 && minprice != 0)
            {
                model = model.Where(p => p.Price < maxprice && p.Price > minprice);
            }
            if (featureIds.Length != 0)
            {
                model = model.Where(p => p.Features.Any(f => featureIds.Contains(f.Id)));
            }

            return View("Phones", model.ToList());
        }
    }
}
