/**  版本信息模板在安装目录下，可自行修改。
* V_StationIp.cs
*
* 功 能： N/A
* 类 名： V_StationIp
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:21   N/A    初版
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
	/// 数据访问类:V_StationIp
	/// </summary>
	public partial class V_StationIp
	{
		public V_StationIp()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.V_StationIp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_StationIp(");
			strSql.Append("AreaCode,AreaName,CompanyCode,companyname,PointCode,PointName,envirlevel,operatedlevel,Name,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,是否运维,是否合同,是否巡检)");
			strSql.Append(" values (");
			strSql.Append("@AreaCode,@AreaName,@CompanyCode,@companyname,@PointCode,@PointName,@envirlevel,@operatedlevel,@Name,@MnCode,@RouterIP,@DataIP,@VedioIP,@LineNo,@Vlan,@NetOperator,@NetType,@是否运维,@是否合同,@是否巡检)");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,20),
					new SqlParameter("@companyname", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@envirlevel", SqlDbType.NVarChar,50),
					new SqlParameter("@operatedlevel", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,100),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@RouterIP", SqlDbType.NVarChar,255),
					new SqlParameter("@DataIP", SqlDbType.NVarChar,255),
					new SqlParameter("@VedioIP", SqlDbType.NVarChar,255),
					new SqlParameter("@LineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Vlan", SqlDbType.NVarChar,20),
					new SqlParameter("@NetOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@NetType", SqlDbType.NVarChar,20),
					new SqlParameter("@是否运维", SqlDbType.VarChar,4),
					new SqlParameter("@是否合同", SqlDbType.VarChar,2),
					new SqlParameter("@是否巡检", SqlDbType.VarChar,6)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.AreaName;
			parameters[2].Value = model.CompanyCode;
			parameters[3].Value = model.companyname;
			parameters[4].Value = model.PointCode;
			parameters[5].Value = model.PointName;
			parameters[6].Value = model.envirlevel;
			parameters[7].Value = model.operatedlevel;
			parameters[8].Value = model.Name;
			parameters[9].Value = model.MnCode;
			parameters[10].Value = model.RouterIP;
			parameters[11].Value = model.DataIP;
			parameters[12].Value = model.VedioIP;
			parameters[13].Value = model.LineNo;
			parameters[14].Value = model.Vlan;
			parameters[15].Value = model.NetOperator;
			parameters[16].Value = model.NetType;
			parameters[17].Value = model.是否运维;
			parameters[18].Value = model.是否合同;
			parameters[19].Value = model.是否巡检;

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
		public bool Update(Maticsoft.Model.V_StationIp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_StationIp set ");
			strSql.Append("AreaCode=@AreaCode,");
			strSql.Append("AreaName=@AreaName,");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("companyname=@companyname,");
			strSql.Append("PointCode=@PointCode,");
			strSql.Append("PointName=@PointName,");
			strSql.Append("envirlevel=@envirlevel,");
			strSql.Append("operatedlevel=@operatedlevel,");
			strSql.Append("Name=@Name,");
			strSql.Append("MnCode=@MnCode,");
			strSql.Append("RouterIP=@RouterIP,");
			strSql.Append("DataIP=@DataIP,");
			strSql.Append("VedioIP=@VedioIP,");
			strSql.Append("LineNo=@LineNo,");
			strSql.Append("Vlan=@Vlan,");
			strSql.Append("NetOperator=@NetOperator,");
			strSql.Append("NetType=@NetType,");
			strSql.Append("是否运维=@是否运维,");
			strSql.Append("是否合同=@是否合同,");
			strSql.Append("是否巡检=@是否巡检");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,20),
					new SqlParameter("@companyname", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@envirlevel", SqlDbType.NVarChar,50),
					new SqlParameter("@operatedlevel", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,100),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@RouterIP", SqlDbType.NVarChar,255),
					new SqlParameter("@DataIP", SqlDbType.NVarChar,255),
					new SqlParameter("@VedioIP", SqlDbType.NVarChar,255),
					new SqlParameter("@LineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Vlan", SqlDbType.NVarChar,20),
					new SqlParameter("@NetOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@NetType", SqlDbType.NVarChar,20),
					new SqlParameter("@是否运维", SqlDbType.VarChar,4),
					new SqlParameter("@是否合同", SqlDbType.VarChar,2),
					new SqlParameter("@是否巡检", SqlDbType.VarChar,6)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.AreaName;
			parameters[2].Value = model.CompanyCode;
			parameters[3].Value = model.companyname;
			parameters[4].Value = model.PointCode;
			parameters[5].Value = model.PointName;
			parameters[6].Value = model.envirlevel;
			parameters[7].Value = model.operatedlevel;
			parameters[8].Value = model.Name;
			parameters[9].Value = model.MnCode;
			parameters[10].Value = model.RouterIP;
			parameters[11].Value = model.DataIP;
			parameters[12].Value = model.VedioIP;
			parameters[13].Value = model.LineNo;
			parameters[14].Value = model.Vlan;
			parameters[15].Value = model.NetOperator;
			parameters[16].Value = model.NetType;
			parameters[17].Value = model.是否运维;
			parameters[18].Value = model.是否合同;
			parameters[19].Value = model.是否巡检;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from V_StationIp ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.V_StationIp GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AreaCode,AreaName,CompanyCode,companyname,PointCode,PointName,envirlevel,operatedlevel,Name,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,是否运维,是否合同,是否巡检 from V_StationIp ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.V_StationIp model=new Maticsoft.Model.V_StationIp();
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
		public Maticsoft.Model.V_StationIp DataRowToModel(DataRow row)
		{
			Maticsoft.Model.V_StationIp model=new Maticsoft.Model.V_StationIp();
			if (row != null)
			{
				if(row["AreaCode"]!=null)
				{
					model.AreaCode=row["AreaCode"].ToString();
				}
				if(row["AreaName"]!=null)
				{
					model.AreaName=row["AreaName"].ToString();
				}
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["companyname"]!=null)
				{
					model.companyname=row["companyname"].ToString();
				}
				if(row["PointCode"]!=null)
				{
					model.PointCode=row["PointCode"].ToString();
				}
				if(row["PointName"]!=null)
				{
					model.PointName=row["PointName"].ToString();
				}
				if(row["envirlevel"]!=null)
				{
					model.envirlevel=row["envirlevel"].ToString();
				}
				if(row["operatedlevel"]!=null)
				{
					model.operatedlevel=row["operatedlevel"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["MnCode"]!=null)
				{
					model.MnCode=row["MnCode"].ToString();
				}
				if(row["RouterIP"]!=null)
				{
					model.RouterIP=row["RouterIP"].ToString();
				}
				if(row["DataIP"]!=null)
				{
					model.DataIP=row["DataIP"].ToString();
				}
				if(row["VedioIP"]!=null)
				{
					model.VedioIP=row["VedioIP"].ToString();
				}
				if(row["LineNo"]!=null)
				{
					model.LineNo=row["LineNo"].ToString();
				}
				if(row["Vlan"]!=null)
				{
					model.Vlan=row["Vlan"].ToString();
				}
				if(row["NetOperator"]!=null)
				{
					model.NetOperator=row["NetOperator"].ToString();
				}
				if(row["NetType"]!=null)
				{
					model.NetType=row["NetType"].ToString();
				}
				if(row["是否运维"]!=null)
				{
					model.是否运维=row["是否运维"].ToString();
				}
				if(row["是否合同"]!=null)
				{
					model.是否合同=row["是否合同"].ToString();
				}
				if(row["是否巡检"]!=null)
				{
					model.是否巡检=row["是否巡检"].ToString();
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
			strSql.Append("select AreaCode,AreaName,CompanyCode,companyname,PointCode,PointName,envirlevel,operatedlevel,Name,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,是否运维,是否合同,是否巡检 ");
			strSql.Append(" FROM V_StationIp ");
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
			strSql.Append(" AreaCode,AreaName,CompanyCode,companyname,PointCode,PointName,envirlevel,operatedlevel,Name,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,是否运维,是否合同,是否巡检 ");
			strSql.Append(" FROM V_StationIp ");
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
			strSql.Append("select count(1) FROM V_StationIp ");
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
				strSql.Append("order by T.StationDevID desc");
			}
			strSql.Append(")AS Row, T.*  from V_StationIp T ");
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
			parameters[0].Value = "V_StationIp";
			parameters[1].Value = "StationDevID";
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

