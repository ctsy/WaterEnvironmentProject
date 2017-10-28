/**  版本信息模板在安装目录下，可自行修改。
* T_EquipmentParts.cs
*
* 功 能： N/A
* 类 名： T_EquipmentParts
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:38   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:T_EquipmentParts
	/// </summary>
	public partial class T_EquipmentParts
	{
		public T_EquipmentParts()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbBaseHelperSQL.GetMaxID("Partsid", "T_EquipmentParts"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Partsid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_EquipmentParts");
			strSql.Append(" where Partsid=@Partsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Partsid", SqlDbType.Int,4)			};
			parameters[0].Value = Partsid;

			return DbBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_EquipmentParts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_EquipmentParts(");
			strSql.Append("Partsid,PartsName,PartsModel,PartsType,PartsUnit,PartStockData,PartsSurplusData,PartsCode,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,Price,Remark)");
			strSql.Append(" values (");
			strSql.Append("@Partsid,@PartsName,@PartsModel,@PartsType,@PartsUnit,@PartStockData,@PartsSurplusData,@PartsCode,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@Price,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@Partsid", SqlDbType.Int,4),
					new SqlParameter("@PartsName", SqlDbType.NVarChar,50),
					new SqlParameter("@PartsModel", SqlDbType.NVarChar,50),
					new SqlParameter("@PartsType", SqlDbType.NVarChar,50),
					new SqlParameter("@PartsUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@PartStockData", SqlDbType.Int,4),
					new SqlParameter("@PartsSurplusData", SqlDbType.Int,4),
					new SqlParameter("@PartsCode", SqlDbType.NVarChar,50),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Float,8),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Partsid;
			parameters[1].Value = model.PartsName;
			parameters[2].Value = model.PartsModel;
			parameters[3].Value = model.PartsType;
			parameters[4].Value = model.PartsUnit;
			parameters[5].Value = model.PartStockData;
			parameters[6].Value = model.PartsSurplusData;
			parameters[7].Value = model.PartsCode;
			parameters[8].Value = model.ExcelServerRCID;
			parameters[9].Value = model.ExcelServerRN;
			parameters[10].Value = model.ExcelServerCN;
			parameters[11].Value = model.ExcelServerRC1;
			parameters[12].Value = model.ExcelServerWIID;
			parameters[13].Value = model.ExcelServerRTID;
			parameters[14].Value = model.ExcelServerCHG;
			parameters[15].Value = model.Price;
			parameters[16].Value = model.Remark;

			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.T_EquipmentParts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_EquipmentParts set ");
			strSql.Append("PartsName=@PartsName,");
			strSql.Append("PartsModel=@PartsModel,");
			strSql.Append("PartsType=@PartsType,");
			strSql.Append("PartsUnit=@PartsUnit,");
			strSql.Append("PartStockData=@PartStockData,");
			strSql.Append("PartsSurplusData=@PartsSurplusData,");
			strSql.Append("PartsCode=@PartsCode,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("Price=@Price,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Partsid=@Partsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@PartsName", SqlDbType.NVarChar,50),
					new SqlParameter("@PartsModel", SqlDbType.NVarChar,50),
					new SqlParameter("@PartsType", SqlDbType.NVarChar,50),
					new SqlParameter("@PartsUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@PartStockData", SqlDbType.Int,4),
					new SqlParameter("@PartsSurplusData", SqlDbType.Int,4),
					new SqlParameter("@PartsCode", SqlDbType.NVarChar,50),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Float,8),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Partsid", SqlDbType.Int,4)};
			parameters[0].Value = model.PartsName;
			parameters[1].Value = model.PartsModel;
			parameters[2].Value = model.PartsType;
			parameters[3].Value = model.PartsUnit;
			parameters[4].Value = model.PartStockData;
			parameters[5].Value = model.PartsSurplusData;
			parameters[6].Value = model.PartsCode;
			parameters[7].Value = model.ExcelServerRCID;
			parameters[8].Value = model.ExcelServerRN;
			parameters[9].Value = model.ExcelServerCN;
			parameters[10].Value = model.ExcelServerRC1;
			parameters[11].Value = model.ExcelServerWIID;
			parameters[12].Value = model.ExcelServerRTID;
			parameters[13].Value = model.ExcelServerCHG;
			parameters[14].Value = model.Price;
			parameters[15].Value = model.Remark;
			parameters[16].Value = model.Partsid;

			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Partsid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_EquipmentParts ");
			strSql.Append(" where Partsid=@Partsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Partsid", SqlDbType.Int,4)			};
			parameters[0].Value = Partsid;

			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Partsidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_EquipmentParts ");
			strSql.Append(" where Partsid in ("+Partsidlist + ")  ");
			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.T_EquipmentParts GetModel(int Partsid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Partsid,PartsName,PartsModel,PartsType,PartsUnit,PartStockData,PartsSurplusData,PartsCode,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,Price,Remark from T_EquipmentParts ");
			strSql.Append(" where Partsid=@Partsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Partsid", SqlDbType.Int,4)			};
			parameters[0].Value = Partsid;

			Maticsoft.Model.T_EquipmentParts model=new Maticsoft.Model.T_EquipmentParts();
			DataSet ds=DbBaseHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.T_EquipmentParts DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_EquipmentParts model=new Maticsoft.Model.T_EquipmentParts();
			if (row != null)
			{
				if(row["Partsid"]!=null && row["Partsid"].ToString()!="")
				{
					model.Partsid=int.Parse(row["Partsid"].ToString());
				}
				if(row["PartsName"]!=null)
				{
					model.PartsName=row["PartsName"].ToString();
				}
				if(row["PartsModel"]!=null)
				{
					model.PartsModel=row["PartsModel"].ToString();
				}
				if(row["PartsType"]!=null)
				{
					model.PartsType=row["PartsType"].ToString();
				}
				if(row["PartsUnit"]!=null)
				{
					model.PartsUnit=row["PartsUnit"].ToString();
				}
				if(row["PartStockData"]!=null && row["PartStockData"].ToString()!="")
				{
					model.PartStockData=int.Parse(row["PartStockData"].ToString());
				}
				if(row["PartsSurplusData"]!=null && row["PartsSurplusData"].ToString()!="")
				{
					model.PartsSurplusData=int.Parse(row["PartsSurplusData"].ToString());
				}
				if(row["PartsCode"]!=null)
				{
					model.PartsCode=row["PartsCode"].ToString();
				}
				if(row["ExcelServerRCID"]!=null)
				{
					model.ExcelServerRCID=row["ExcelServerRCID"].ToString();
				}
				if(row["ExcelServerRN"]!=null && row["ExcelServerRN"].ToString()!="")
				{
					model.ExcelServerRN=int.Parse(row["ExcelServerRN"].ToString());
				}
				if(row["ExcelServerCN"]!=null && row["ExcelServerCN"].ToString()!="")
				{
					model.ExcelServerCN=int.Parse(row["ExcelServerCN"].ToString());
				}
				if(row["ExcelServerRC1"]!=null)
				{
					model.ExcelServerRC1=row["ExcelServerRC1"].ToString();
				}
				if(row["ExcelServerWIID"]!=null)
				{
					model.ExcelServerWIID=row["ExcelServerWIID"].ToString();
				}
				if(row["ExcelServerRTID"]!=null)
				{
					model.ExcelServerRTID=row["ExcelServerRTID"].ToString();
				}
				if(row["ExcelServerCHG"]!=null && row["ExcelServerCHG"].ToString()!="")
				{
					model.ExcelServerCHG=int.Parse(row["ExcelServerCHG"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Partsid,PartsName,PartsModel,PartsType,PartsUnit,PartStockData,PartsSurplusData,PartsCode,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,Price,Remark ");
			strSql.Append(" FROM T_EquipmentParts ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbBaseHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Partsid,PartsName,PartsModel,PartsType,PartsUnit,PartStockData,PartsSurplusData,PartsCode,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,Price,Remark ");
			strSql.Append(" FROM T_EquipmentParts ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbBaseHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_EquipmentParts ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Partsid desc");
			}
			strSql.Append(")AS Row, T.*  from T_EquipmentParts T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbBaseHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_EquipmentParts";
			parameters[1].Value = "Partsid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbBaseHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

