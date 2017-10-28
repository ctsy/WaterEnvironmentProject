/**  版本信息模板在安装目录下，可自行修改。
* T_Company.cs
*
* 功 能： N/A
* 类 名： T_Company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:34   N/A    初版
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
	/// 数据访问类:T_Company
	/// </summary>
	public partial class T_Company
	{
		public T_Company()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CompanyCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Company");
			strSql.Append(" where CompanyCode=@CompanyCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255)			};
			parameters[0].Value = CompanyCode;

			return DbBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_Company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Company(");
			strSql.Append("AreaCode,CompanyCode,CompanyName,CompanyType,CompanyIndustry,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyAddress,Town,Street,CompanyIsStop,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,contrator,AreaID,Longitude,latitude)");
			strSql.Append(" values (");
			strSql.Append("@AreaCode,@CompanyCode,@CompanyName,@CompanyType,@CompanyIndustry,@CompanyPhone,@CompanyLegal,@CompanyLegalNo,@CompanyAddress,@Town,@Street,@CompanyIsStop,@remark,@UpdateTime,@UpdatePerson,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@contrator,@AreaID,@Longitude,@latitude)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyType", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIndustry", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegal", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegalNo", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@Town", SqlDbType.NVarChar,255),
					new SqlParameter("@Street", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIsStop", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdatePerson", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@contrator", SqlDbType.NVarChar,100),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@Longitude", SqlDbType.Decimal,9),
					new SqlParameter("@latitude", SqlDbType.Decimal,9)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.CompanyCode;
			parameters[2].Value = model.CompanyName;
			parameters[3].Value = model.CompanyType;
			parameters[4].Value = model.CompanyIndustry;
			parameters[5].Value = model.CompanyPhone;
			parameters[6].Value = model.CompanyLegal;
			parameters[7].Value = model.CompanyLegalNo;
			parameters[8].Value = model.CompanyAddress;
			parameters[9].Value = model.Town;
			parameters[10].Value = model.Street;
			parameters[11].Value = model.CompanyIsStop;
			parameters[12].Value = model.remark;
			parameters[13].Value = model.UpdateTime;
			parameters[14].Value = model.UpdatePerson;
			parameters[15].Value = model.ExcelServerRCID;
			parameters[16].Value = model.ExcelServerRN;
			parameters[17].Value = model.ExcelServerCN;
			parameters[18].Value = model.ExcelServerRC1;
			parameters[19].Value = model.ExcelServerWIID;
			parameters[20].Value = model.ExcelServerRTID;
			parameters[21].Value = model.ExcelServerCHG;
			parameters[22].Value = model.contrator;
			parameters[23].Value = model.AreaID;
			parameters[24].Value = model.Longitude;
			parameters[25].Value = model.latitude;

			object obj = DbBaseHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.T_Company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Company set ");
			strSql.Append("AreaCode=@AreaCode,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyType=@CompanyType,");
			strSql.Append("CompanyIndustry=@CompanyIndustry,");
			strSql.Append("CompanyPhone=@CompanyPhone,");
			strSql.Append("CompanyLegal=@CompanyLegal,");
			strSql.Append("CompanyLegalNo=@CompanyLegalNo,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("Town=@Town,");
			strSql.Append("Street=@Street,");
			strSql.Append("CompanyIsStop=@CompanyIsStop,");
			strSql.Append("remark=@remark,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("UpdatePerson=@UpdatePerson,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("contrator=@contrator,");
			strSql.Append("AreaID=@AreaID,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("latitude=@latitude");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyType", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIndustry", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegal", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegalNo", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@Town", SqlDbType.NVarChar,255),
					new SqlParameter("@Street", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIsStop", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdatePerson", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@contrator", SqlDbType.NVarChar,100),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@Longitude", SqlDbType.Decimal,9),
					new SqlParameter("@latitude", SqlDbType.Decimal,9),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.CompanyName;
			parameters[2].Value = model.CompanyType;
			parameters[3].Value = model.CompanyIndustry;
			parameters[4].Value = model.CompanyPhone;
			parameters[5].Value = model.CompanyLegal;
			parameters[6].Value = model.CompanyLegalNo;
			parameters[7].Value = model.CompanyAddress;
			parameters[8].Value = model.Town;
			parameters[9].Value = model.Street;
			parameters[10].Value = model.CompanyIsStop;
			parameters[11].Value = model.remark;
			parameters[12].Value = model.UpdateTime;
			parameters[13].Value = model.UpdatePerson;
			parameters[14].Value = model.ExcelServerRCID;
			parameters[15].Value = model.ExcelServerRN;
			parameters[16].Value = model.ExcelServerCN;
			parameters[17].Value = model.ExcelServerRC1;
			parameters[18].Value = model.ExcelServerWIID;
			parameters[19].Value = model.ExcelServerRTID;
			parameters[20].Value = model.ExcelServerCHG;
			parameters[21].Value = model.contrator;
			parameters[22].Value = model.AreaID;
			parameters[23].Value = model.Longitude;
			parameters[24].Value = model.latitude;
			parameters[25].Value = model.CompanyCode;
			parameters[26].Value = model.CompanyID;

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
		public bool Delete(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Company ");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)
			};
			parameters[0].Value = CompanyID;

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
		public bool Delete(string CompanyCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Company ");
			strSql.Append(" where CompanyCode=@CompanyCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255)			};
			parameters[0].Value = CompanyCode;

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
		public bool DeleteList(string CompanyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Company ");
			strSql.Append(" where CompanyID in ("+CompanyIDlist + ")  ");
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
		public Maticsoft.Model.T_Company GetModel(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AreaCode,CompanyCode,CompanyName,CompanyType,CompanyIndustry,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyAddress,Town,Street,CompanyIsStop,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,contrator,CompanyID,AreaID,Longitude,latitude from T_Company ");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)
			};
			parameters[0].Value = CompanyID;

			Maticsoft.Model.T_Company model=new Maticsoft.Model.T_Company();
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
		public Maticsoft.Model.T_Company DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Company model=new Maticsoft.Model.T_Company();
			if (row != null)
			{
				if(row["AreaCode"]!=null)
				{
					model.AreaCode=row["AreaCode"].ToString();
				}
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["CompanyType"]!=null)
				{
					model.CompanyType=row["CompanyType"].ToString();
				}
				if(row["CompanyIndustry"]!=null)
				{
					model.CompanyIndustry=row["CompanyIndustry"].ToString();
				}
				if(row["CompanyPhone"]!=null)
				{
					model.CompanyPhone=row["CompanyPhone"].ToString();
				}
				if(row["CompanyLegal"]!=null)
				{
					model.CompanyLegal=row["CompanyLegal"].ToString();
				}
				if(row["CompanyLegalNo"]!=null)
				{
					model.CompanyLegalNo=row["CompanyLegalNo"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
				}
				if(row["Town"]!=null)
				{
					model.Town=row["Town"].ToString();
				}
				if(row["Street"]!=null)
				{
					model.Street=row["Street"].ToString();
				}
				if(row["CompanyIsStop"]!=null && row["CompanyIsStop"].ToString()!="")
				{
					if((row["CompanyIsStop"].ToString()=="1")||(row["CompanyIsStop"].ToString().ToLower()=="true"))
					{
						model.CompanyIsStop=true;
					}
					else
					{
						model.CompanyIsStop=false;
					}
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["UpdatePerson"]!=null)
				{
					model.UpdatePerson=row["UpdatePerson"].ToString();
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
				if(row["contrator"]!=null)
				{
					model.contrator=row["contrator"].ToString();
				}
				if(row["CompanyID"]!=null && row["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(row["CompanyID"].ToString());
				}
				if(row["AreaID"]!=null && row["AreaID"].ToString()!="")
				{
					model.AreaID=int.Parse(row["AreaID"].ToString());
				}
				if(row["Longitude"]!=null && row["Longitude"].ToString()!="")
				{
					model.Longitude=decimal.Parse(row["Longitude"].ToString());
				}
				if(row["latitude"]!=null && row["latitude"].ToString()!="")
				{
					model.latitude=decimal.Parse(row["latitude"].ToString());
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
			strSql.Append("select AreaCode,CompanyCode,CompanyName,CompanyType,CompanyIndustry,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyAddress,Town,Street,CompanyIsStop,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,contrator,CompanyID,AreaID,Longitude,latitude ");
			strSql.Append(" FROM T_Company ");
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
			strSql.Append(" AreaCode,CompanyCode,CompanyName,CompanyType,CompanyIndustry,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyAddress,Town,Street,CompanyIsStop,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,contrator,CompanyID,AreaID,Longitude,latitude ");
			strSql.Append(" FROM T_Company ");
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
			strSql.Append("select count(1) FROM T_Company ");
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
				strSql.Append("order by T.CompanyID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Company T ");
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
			parameters[0].Value = "T_Company";
			parameters[1].Value = "CompanyID";
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

