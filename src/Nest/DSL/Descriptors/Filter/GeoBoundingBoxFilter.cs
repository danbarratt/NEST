﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Nest
{
	public class GeoBoundingBoxFilter : FilterBase
	{
		[JsonProperty("top_left")]
		public string TopLeft { get; set; }
		[JsonProperty("bottom_right")]
		public string BottomRight { get; set; }

	}
}
