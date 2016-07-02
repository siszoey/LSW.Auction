﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using 拍卖系统.Models;

namespace 拍卖系统.Areas.Admin.Models
{
	public class MenuModel : EntityBase<int>
	{
		public MenuModel()
		{
			GroupItems = new List<Groupitem>();
		}
		public string GroupIDX { get; set; }
		[Display(Name = "组名")]
		public string GroupName { get; set; }
		[Display(Name = "图标")]
		public string GroupICO { get; set; }
		public ICollection<Groupitem> GroupItems { get; set; }
		[Display(Name = "控制器名")]
		public string ControllerName { get; set; }
	}

	public class Groupitem : EntityBase<int>
	{
		public virtual MenuModel Group { get; set; }
		public string ItemIDX { get; set; }
		public string ItemName { get; set; }
		public string ItemDesc { get; set; }
		public string ItemURL { get; set; }
		public string ItemICO { get; set; }
		public string ActionName { get; set; }
	}
}
