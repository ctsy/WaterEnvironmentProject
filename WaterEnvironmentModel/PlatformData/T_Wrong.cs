/**  版本信息模板在安装目录下，可自行修改。
* T_Wrong.cs
*
* 功 能： N/A
* 类 名： T_Wrong
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:54   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// T_Wrong:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Wrong
	{
		public T_Wrong()
		{}
		#region Model
		private int _id;
		private string _problemcode;
		private string _problemname;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProblemCode
		{
			set{ _problemcode=value;}
			get{return _problemcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProblemName
		{
			set{ _problemname=value;}
			get{return _problemname;}
		}
		#endregion Model

	}
}

