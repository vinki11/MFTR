﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.DbConnexion.Helper
{
	class Helper
	{
		/// <summary>
		/// Méthode qui bind un sur une propriété spécifique en fonction d'un object
		/// </summary>
		/// <param name="object">Object à binder</param>
		/// <param name="propertyName">la propriété</param>
		/// <returns></returns>
		public static string BindProperty(object @object, string propertyName)
		{
			string retValue = "";

			if (propertyName.Contains("."))
			{
				PropertyInfo[] arrayProperties;
				string leftPropertyName;

				leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
				arrayProperties = @object.GetType().GetProperties();

				foreach (PropertyInfo propertyInfo in arrayProperties)
				{
					if (propertyInfo.Name == leftPropertyName)
					{
						retValue = BindProperty(
							propertyInfo.GetValue(@object, null),
							propertyName.Substring(propertyName.IndexOf(".") + 1));
						break;
					}
				}
			}
			else
			{
				Type propertyType;
				PropertyInfo propertyInfo;

				propertyType = @object.GetType();
				propertyInfo = propertyType.GetProperty(propertyName);
				retValue = propertyInfo.GetValue(@object, null).ToString();
			}

			return retValue;
		}
	}
}
