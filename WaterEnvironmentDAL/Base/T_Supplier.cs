/**  版本信息模板在安装目录下，可自行修改。
* T_Supplier.cs
*
* 功 能： N/A
* 类 名： T_Supplier
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:59   N/A    初版
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
	/// 数据访问类:T_Supplier
	/// </summary>
	public partial class T_Supplier
	{
		public T_Supplier()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbBaseHelperSQL.GetMaxID("SupplierId", "T_Supplier"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SupplierId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Supplier");
			strSql.Append(" where SupplierId=@SupplierId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplierId", SqlDbType.Int,4)			};
			parameters[0].Value = SupplierId;

			return DbBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_Supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Supplier(");
			strSql.Append("SupplierId,SupplierName,Address,Phone,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG)");
			strSql.Append(" values (");
			strSql.Append("@SupplierId,@SupplierName,@Address,@Phone,@Remark,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG)");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplierId", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,255),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4)};
			parameters[0].Value = model.SupplierId;
			parameters[1].Value = model.SupplierName;
			parameters[2].Value = model.Address;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.ExcelServerRCID;
			parameters[6].Value = model.ExcelServerRN;
			parameters[7].Value = model.ExcelServerCN;
			parameters[8].Value = model.ExcelServerRC1;
			parameters[9].Value = model.ExcelServerWIID;
			parameters[10].Value = model.ExcelServerRTID;
			parameters[11].Value = model.ExcelServerCHG;

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
		public bool Update(Maticsoft.Model.T_Supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Supplier set ");
			strSql.Append("SupplierName=@SupplierName,");
			strSql.Append("Address=@Address,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG");
			strSql.Append(" where SupplierId=@SupplierId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,255),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@SupplierId", SqlDbType.Int,4)};
			parameters[0].Value = model.SupplierName;
			parameters[1].Value = model.Address;
			parameters[2].Value = model.Phone;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.ExcelServerRCID;
			parameters[5].Value = model.ExcelServerRN;
			parameters[6].Value = model.ExcelServerCN;
			parameters[7].Value = model.ExcelServerRC1;
			parameters[8].Value = model.ExcelServerWIID;
			parameters[9].Value = model.ExcelServerRTID;
			parameters[10].Value = model.ExcelServerCHG;
			parameters[11].Value = model.SupplierId;

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
		public bool Delete(int SupplierId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Supplier ");
			strSql.Append(" where SupplierId=@SupplierId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplierId", SqlDbType.Int,4)			};
			parameters[0].Value = SupplierId;

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
		public bool DeleteList(string SupplierIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Supplier ");
			strSql.Append(" where SupplierId in ("+SupplierIdlist + ")  ");
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
		public Maticsoft.Model.T_Supplier GetModel(int SupplierId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SupplierId,SupplierName,Address,Phone,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG from T_Supplier ");
			strSql.Append(" where SupplierId=@SupplierId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplierId", SqlDbType.Int,4)			};
			parameters[0].Value = SupplierId;

			Maticsoft.Model.T_Supplier model=new Maticsoft.Model.T_Supplier();
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
		public Maticsoft.Model.T_Supplier DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Supplier model=new Maticsoft.Model.T_Supplier();
			if (row != null)
			{
				if(row["SupplierId"]!=null && row["SupplierId"].ToString()!="")
				{
					model.SupplierId=int.Parse(row["SupplierId"].ToString());
				}
				if(row["SupplierName"]!=null)
				{
					model.SupplierName=row["SupplierName"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SupplierId,SupplierName,Address,Phone,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_Supplier ");
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
			strSql.Append(" SupplierId,SupplierName,Address,Phone,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_Supplier ");
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
			strSql.Append("select count(1) FROM T_Supplier ");
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
				strSql.Append("order by T.SupplierId desc");
			}
			strSql.Append(")AS Row, T.*  from T_Supplier T ");
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
			parameters[0].Value = "T_Supplier";
			parameters[1].Value = "SupplierId";
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

