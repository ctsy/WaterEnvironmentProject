﻿/**  版本信息模板在安装目录下，可自行修改。
* V_Company.cs
*
* 功 能： N/A
* 类 名： V_Company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:13   N/A    初版
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
	/// 数据访问类:V_Company
	/// </summary>
	public partial class V_Company
	{
		public V_Company()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.V_Company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_Company(");
			strSql.Append("AreaCode,areaname,companycode,companyname,CompanyType,CompanyIndustry,CompanyAddress,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyIsStop,是否运维,town,Street,remark,UpdateTime,UpdatePerson,AreaID)");
			strSql.Append(" values (");
			strSql.Append("@AreaCode,@areaname,@companycode,@companyname,@CompanyType,@CompanyIndustry,@CompanyAddress,@CompanyPhone,@CompanyLegal,@CompanyLegalNo,@CompanyIsStop,@是否运维,@town,@Street,@remark,@UpdateTime,@UpdatePerson,@AreaID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@areaname", SqlDbType.NVarChar,255),
					new SqlParameter("@companycode", SqlDbType.NVarChar,255),
					new SqlParameter("@companyname", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyType", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIndustry", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegal", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegalNo", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIsStop", SqlDbType.Bit,1),
					new SqlParameter("@是否运维", SqlDbType.VarChar,2),
					new SqlParameter("@town", SqlDbType.NVarChar,255),
					new SqlParameter("@Street", SqlDbType.NVarChar,255),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdatePerson", SqlDbType.NVarChar,255),
					new SqlParameter("@AreaID", SqlDbType.Int,4)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.areaname;
			parameters[2].Value = model.companycode;
			parameters[3].Value = model.companyname;
			parameters[4].Value = model.CompanyType;
			parameters[5].Value = model.CompanyIndustry;
			parameters[6].Value = model.CompanyAddress;
			parameters[7].Value = model.CompanyPhone;
			parameters[8].Value = model.CompanyLegal;
			parameters[9].Value = model.CompanyLegalNo;
			parameters[10].Value = model.CompanyIsStop;
			parameters[11].Value = model.是否运维;
			parameters[12].Value = model.town;
			parameters[13].Value = model.Street;
			parameters[14].Value = model.remark;
			parameters[15].Value = model.UpdateTime;
			parameters[16].Value = model.UpdatePerson;
			parameters[17].Value = model.AreaID;

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
		public bool Update(Maticsoft.Model.V_Company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_Company set ");
			strSql.Append("AreaCode=@AreaCode,");
			strSql.Append("areaname=@areaname,");
			strSql.Append("companycode=@companycode,");
			strSql.Append("companyname=@companyname,");
			strSql.Append("CompanyType=@CompanyType,");
			strSql.Append("CompanyIndustry=@CompanyIndustry,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("CompanyPhone=@CompanyPhone,");
			strSql.Append("CompanyLegal=@CompanyLegal,");
			strSql.Append("CompanyLegalNo=@CompanyLegalNo,");
			strSql.Append("CompanyIsStop=@CompanyIsStop,");
			strSql.Append("是否运维=@是否运维,");
			strSql.Append("town=@town,");
			strSql.Append("Street=@Street,");
			strSql.Append("remark=@remark,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("UpdatePerson=@UpdatePerson,");
			strSql.Append("AreaID=@AreaID");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@areaname", SqlDbType.NVarChar,255),
					new SqlParameter("@companycode", SqlDbType.NVarChar,255),
					new SqlParameter("@companyname", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyType", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIndustry", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegal", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyLegalNo", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyIsStop", SqlDbType.Bit,1),
					new SqlParameter("@是否运维", SqlDbType.VarChar,2),
					new SqlParameter("@town", SqlDbType.NVarChar,255),
					new SqlParameter("@Street", SqlDbType.NVarChar,255),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdatePerson", SqlDbType.NVarChar,255),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.areaname;
			parameters[2].Value = model.companycode;
			parameters[3].Value = model.companyname;
			parameters[4].Value = model.CompanyType;
			parameters[5].Value = model.CompanyIndustry;
			parameters[6].Value = model.CompanyAddress;
			parameters[7].Value = model.CompanyPhone;
			parameters[8].Value = model.CompanyLegal;
			parameters[9].Value = model.CompanyLegalNo;
			parameters[10].Value = model.CompanyIsStop;
			parameters[11].Value = model.是否运维;
			parameters[12].Value = model.town;
			parameters[13].Value = model.Street;
			parameters[14].Value = model.remark;
			parameters[15].Value = model.UpdateTime;
			parameters[16].Value = model.UpdatePerson;
			parameters[17].Value = model.AreaID;
			parameters[18].Value = model.CompanyID;

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
			strSql.Append("delete from V_Company ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string CompanyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from V_Company ");
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
		public Maticsoft.Model.V_Company GetModel(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AreaCode,areaname,companycode,companyname,CompanyType,CompanyIndustry,CompanyAddress,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyIsStop,是否运维,town,Street,remark,UpdateTime,UpdatePerson,CompanyID,AreaID from V_Company ");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)
			};
			parameters[0].Value = CompanyID;

			Maticsoft.Model.V_Company model=new Maticsoft.Model.V_Company();
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
		public Maticsoft.Model.V_Company DataRowToModel(DataRow row)
		{
			Maticsoft.Model.V_Company model=new Maticsoft.Model.V_Company();
			if (row != null)
			{
				if(row["AreaCode"]!=null)
				{
					model.AreaCode=row["AreaCode"].ToString();
				}
				if(row["areaname"]!=null)
				{
					model.areaname=row["areaname"].ToString();
				}
				if(row["companycode"]!=null)
				{
					model.companycode=row["companycode"].ToString();
				}
				if(row["companyname"]!=null)
				{
					model.companyname=row["companyname"].ToString();
				}
				if(row["CompanyType"]!=null)
				{
					model.CompanyType=row["CompanyType"].ToString();
				}
				if(row["CompanyIndustry"]!=null)
				{
					model.CompanyIndustry=row["CompanyIndustry"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
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
				if(row["是否运维"]!=null)
				{
					model.是否运维=row["是否运维"].ToString();
				}
				if(row["town"]!=null)
				{
					model.town=row["town"].ToString();
				}
				if(row["Street"]!=null)
				{
					model.Street=row["Street"].ToString();
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
				if(row["CompanyID"]!=null && row["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(row["CompanyID"].ToString());
				}
				if(row["AreaID"]!=null && row["AreaID"].ToString()!="")
				{
					model.AreaID=int.Parse(row["AreaID"].ToString());
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
			strSql.Append("select AreaCode,areaname,companycode,companyname,CompanyType,CompanyIndustry,CompanyAddress,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyIsStop,是否运维,town,Street,remark,UpdateTime,UpdatePerson,CompanyID,AreaID ");
			strSql.Append(" FROM V_Company ");
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
			strSql.Append(" AreaCode,areaname,companycode,companyname,CompanyType,CompanyIndustry,CompanyAddress,CompanyPhone,CompanyLegal,CompanyLegalNo,CompanyIsStop,是否运维,town,Street,remark,UpdateTime,UpdatePerson,CompanyID,AreaID ");
			strSql.Append(" FROM V_Company ");
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
			strSql.Append("select count(1) FROM V_Company ");
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
			strSql.Append(")AS Row, T.*  from V_Company T ");
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
			parameters[0].Value = "V_Company";
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

