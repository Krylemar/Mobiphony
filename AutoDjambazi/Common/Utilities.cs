namespace AutoDjambazi.Common
{
    /// <summary>Клас за всеобщо ползване - съдържа поезни функции</summary>
    public static class Utilities
	{
		//-------------------------
		//Constants:
		//-------------------------

		//-------------------------
		//Members:
		//-------------------------

		//-------------------------
		//Properties:
		//-------------------------

		//-------------------------
		//Constructor/Destructor:
		//-------------------------

		//-------------------------
		//Methods:
		//-------------------------

		//TO DO Adam - не е тествано ще се чуе
		public static Type? LinerSearchSimple<Type>(IEnumerable<Type> collection, Func<Type, bool> action)
		{
			for (int index = 0; index < collection.Count(); index++)
			{
				var currentElement = collection.ElementAt(index);
				if (action(currentElement))
					return currentElement;
			}

			return default;
		}

        //-------------------------
        //Overrides:
        //-------------------------
    }
}
