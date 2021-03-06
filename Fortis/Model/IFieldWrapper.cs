﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Fortis.Model
{
    public interface IFieldWrapper : IWrapper, IHtmlString
	{
		string RawValue { get; set; }
		bool Modified { get; }
		IHtmlString Render(string parameters = null, bool editing = true);
		string ToString();
		bool IsLazy { get; }
	}

	public interface IFieldWrapper<T> : IFieldWrapper
	{
		T Value { get; }
	}
}
