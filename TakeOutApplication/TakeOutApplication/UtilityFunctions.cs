using System;
using System.Collections.Generic;
using System.Text;

namespace TakeOutApplication
{
    public static class UtilityFunctions
    {
        public static string ConvertStatusCodeToString(int statusCode)
        {
			if (statusCode == 0) return "Zamówione";
			if (statusCode == 1) return "Przyjęte";
			if (statusCode == 2) return "Przygotowane";
			if (statusCode == 3) return "Dostarczone";
			if (statusCode == 4) return "Zamknięte";
			else throw new Exception($"Provided code {statusCode} is not recognized");
		}
	}
}
