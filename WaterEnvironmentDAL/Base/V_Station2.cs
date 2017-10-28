/**  版本信息模板在安装目录下，可自行修改。
* V_Station2.cs
*
* 功 能： N/A
* 类 名： V_Station2
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:15   N/A    初版
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
	/// 数据访问类:V_Station2
	/// </summary>
	public partial class V_Station2
	{
		public V_Station2()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.V_Station2 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_Station2(");
			strSql.Append("AreaName,CompanyCode,CompanyName,PointCode,PointCode1,PointName,PointUses,是否运维,IsPatrol,是否巡检,IsContract,是否合同,PointType,Name,OutletNo,PassTime,EnvirLevel,OperatedLevel,OperatedCenter,OperatedGroup,Director,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,CompanyID,PointID,AreaCode,PointCodeB,frequency,latitude,Longitude,Pointaddress)");
			strSql.Append(" values (");
			strSql.Append("@AreaName,@CompanyCode,@CompanyName,@PointCode,@PointCode1,@PointName,@PointUses,@是否运维,@IsPatrol,@是否巡检,@IsContract,@是否合同,@PointType,@Name,@OutletNo,@PassTime,@EnvirLevel,@OperatedLevel,@OperatedCenter,@OperatedGroup,@Director,@MnCode,@RouterIP,@DataIP,@VedioIP,@LineNo,@Vlan,@NetOperator,@NetType,@remark,@UpdateTime,@UpdatePerson,@CompanyID,@PointID,@AreaCode,@PointCodeB,@frequency,@latitude,@Longitude,@Pointaddress)");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointCode1", SqlDbType.NVarChar,20),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointUses", SqlDbType.Bit,1),
					new SqlParameter("@是否运维", SqlDbType.VarChar,4),
					new SqlParameter("@IsPatrol", SqlDbType.Bit,1),
					new SqlParameter("@是否巡检", SqlDbType.VarChar,6),
					new SqlParameter("@IsContract", SqlDbType.Bit,1),
					new SqlParameter("@是否合同", SqlDbType.VarChar,2),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,100),
					new SqlParameter("@OutletNo", SqlDbType.NVarChar,20),
					new SqlParameter("@PassTime", SqlDbType.DateTime),
					new SqlParameter("@EnvirLevel", SqlDbType.NVarChar,50),
					new SqlParameter("@OperatedLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedCenter", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedGroup", SqlDbType.NVarChar,20),
					new SqlParameter("@Director", SqlDbType.NVarChar,50),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@RouterIP", SqlDbType.NVarChar,255),
					new SqlParameter("@DataIP", SqlDbType.NVarChar,255),
					new SqlParameter("@VedioIP", SqlDbType.NVarChar,255),
					new SqlParameter("@LineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Vlan", SqlDbType.NVarChar,20),
					new SqlParameter("@NetOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@NetType", SqlDbType.NVarChar,20),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdatePerson", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@PointCodeB", SqlDbType.NVarChar,50),
					new SqlParameter("@frequency", SqlDbType.Int,4),
					new SqlParameter("@latitude", SqlDbType.NVarChar,50),
					new SqlParameter("@Longitude", SqlDbType.NVarChar,50),
					new SqlParameter("@Pointaddress", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.AreaName;
			parameters[1].Value = model.CompanyCode;
			parameters[2].Value = model.CompanyName;
			parameters[3].Value = model.PointCode;
			parameters[4].Value = model.PointCode1;
			parameters[5].Value = model.PointName;
			parameters[6].Value = model.PointUses;
			parameters[7].Value = model.是否运维;
			parameters[8].Value = model.IsPatrol;
			parameters[9].Value = model.是否巡检;
			parameters[10].Value = model.IsContract;
			parameters[11].Value = model.是否合同;
			parameters[12].Value = model.PointType;
			parameters[13].Value = model.Name;
			parameters[14].Value = model.OutletNo;
			parameters[15].Value = model.PassTime;
			parameters[16].Value = model.EnvirLevel;
			parameters[17].Value = model.OperatedLevel;
			parameters[18].Value = model.OperatedCenter;
			parameters[19].Value = model.OperatedGroup;
			parameters[20].Value = model.Director;
			parameters[21].Value = model.MnCode;
			parameters[22].Value = model.RouterIP;
			parameters[23].Value = model.DataIP;
			parameters[24].Value = model.VedioIP;
			parameters[25].Value = model.LineNo;
			parameters[26].Value = model.Vlan;
			parameters[27].Value = model.NetOperator;
			parameters[28].Value = model.NetType;
			parameters[29].Value = model.remark;
			parameters[30].Value = model.UpdateTime;
			parameters[31].Value = model.UpdatePerson;
			parameters[32].Value = model.CompanyID;
			parameters[33].Value = model.PointID;
			parameters[34].Value = model.AreaCode;
			parameters[35].Value = model.PointCodeB;
			parameters[36].Value = model.frequency;
			parameters[37].Value = model.latitude;
			parameters[38].Value = model.Longitude;
			parameters[39].Value = model.Pointaddress;

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
		public bool Update(Maticsoft.Model.V_Station2 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_Station2 set ");
			strSql.Append("AreaName=@AreaName,");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("PointCode=@PointCode,");
			strSql.Append("PointCode1=@PointCode1,");
			strSql.Append("PointName=@PointName,");
			strSql.Append("PointUses=@PointUses,");
			strSql.Append("是否运维=@是否运维,");
			strSql.Append("IsPatrol=@IsPatrol,");
			strSql.Append("是否巡检=@是否巡检,");
			strSql.Append("IsContract=@IsContract,");
			strSql.Append("是否合同=@是否合同,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("Name=@Name,");
			strSql.Append("OutletNo=@OutletNo,");
			strSql.Append("PassTime=@PassTime,");
			strSql.Append("EnvirLevel=@EnvirLevel,");
			strSql.Append("OperatedLevel=@OperatedLevel,");
			strSql.Append("OperatedCenter=@OperatedCenter,");
			strSql.Append("OperatedGroup=@OperatedGroup,");
			strSql.Append("Director=@Director,");
			strSql.Append("MnCode=@MnCode,");
			strSql.Append("RouterIP=@RouterIP,");
			strSql.Append("DataIP=@DataIP,");
			strSql.Append("VedioIP=@VedioIP,");
			strSql.Append("LineNo=@LineNo,");
			strSql.Append("Vlan=@Vlan,");
			strSql.Append("NetOperator=@NetOperator,");
			strSql.Append("NetType=@NetType,");
			strSql.Append("remark=@remark,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("UpdatePerson=@UpdatePerson,");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("AreaCode=@AreaCode,");
			strSql.Append("PointCodeB=@PointCodeB,");
			strSql.Append("frequency=@frequency,");
			strSql.Append("latitude=@latitude,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Pointaddress=@Pointaddress");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointCode1", SqlDbType.NVarChar,20),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointUses", SqlDbType.Bit,1),
					new SqlParameter("@是否运维", SqlDbType.VarChar,4),
					new SqlParameter("@IsPatrol", SqlDbType.Bit,1),
					new SqlParameter("@是否巡检", SqlDbType.VarChar,6),
					new SqlParameter("@IsContract", SqlDbType.Bit,1),
					new SqlParameter("@是否合同", SqlDbType.VarChar,2),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,100),
					new SqlParameter("@OutletNo", SqlDbType.NVarChar,20),
					new SqlParameter("@PassTime", SqlDbType.DateTime),
					new SqlParameter("@EnvirLevel", SqlDbType.NVarChar,50),
					new SqlParameter("@OperatedLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedCenter", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedGroup", SqlDbType.NVarChar,20),
					new SqlParameter("@Director", SqlDbType.NVarChar,50),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@RouterIP", SqlDbType.NVarChar,255),
					new SqlParameter("@DataIP", SqlDbType.NVarChar,255),
					new SqlParameter("@VedioIP", SqlDbType.NVarChar,255),
					new SqlParameter("@LineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Vlan", SqlDbType.NVarChar,20),
					new SqlParameter("@NetOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@NetType", SqlDbType.NVarChar,20),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdatePerson", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@PointCodeB", SqlDbType.NVarChar,50),
					new SqlParameter("@frequency", SqlDbType.Int,4),
					new SqlParameter("@latitude", SqlDbType.NVarChar,50),
					new SqlParameter("@Longitude", SqlDbType.NVarChar,50),
					new SqlParameter("@Pointaddress", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.AreaName;
			parameters[1].Value = model.CompanyCode;
			parameters[2].Value = model.CompanyName;
			parameters[3].Value = model.PointCode;
			parameters[4].Value = model.PointCode1;
			parameters[5].Value = model.PointName;
			parameters[6].Value = model.PointUses;
			parameters[7].Value = model.是否运维;
			parameters[8].Value = model.IsPatrol;
			parameters[9].Value = model.是否巡检;
			parameters[10].Value = model.IsContract;
			parameters[11].Value = model.是否合同;
			parameters[12].Value = model.PointType;
			parameters[13].Value = model.Name;
			parameters[14].Value = model.OutletNo;
			parameters[15].Value = model.PassTime;
			parameters[16].Value = model.EnvirLevel;
			parameters[17].Value = model.OperatedLevel;
			parameters[18].Value = model.OperatedCenter;
			parameters[19].Value = model.OperatedGroup;
			parameters[20].Value = model.Director;
			parameters[21].Value = model.MnCode;
			parameters[22].Value = model.RouterIP;
			parameters[23].Value = model.DataIP;
			parameters[24].Value = model.VedioIP;
			parameters[25].Value = model.LineNo;
			parameters[26].Value = model.Vlan;
			parameters[27].Value = model.NetOperator;
			parameters[28].Value = model.NetType;
			parameters[29].Value = model.remark;
			parameters[30].Value = model.UpdateTime;
			parameters[31].Value = model.UpdatePerson;
			parameters[32].Value = model.CompanyID;
			parameters[33].Value = model.PointID;
			parameters[34].Value = model.AreaCode;
			parameters[35].Value = model.PointCodeB;
			parameters[36].Value = model.frequency;
			parameters[37].Value = model.latitude;
			parameters[38].Value = model.Longitude;
			parameters[39].Value = model.Pointaddress;

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
			strSql.Append("delete from V_Station2 ");
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
		public Maticsoft.Model.V_Station2 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AreaName,CompanyCode,CompanyName,PointCode,PointCode1,PointName,PointUses,是否运维,IsPatrol,是否巡检,IsContract,是否合同,PointType,Name,OutletNo,PassTime,EnvirLevel,OperatedLevel,OperatedCenter,OperatedGroup,Director,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,CompanyID,PointID,AreaCode,PointCodeB,frequency,latitude,Longitude,Pointaddress from V_Station2 ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.V_Station2 model=new Maticsoft.Model.V_Station2();
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
		public Maticsoft.Model.V_Station2 DataRowToModel(DataRow row)
		{
			Maticsoft.Model.V_Station2 model=new Maticsoft.Model.V_Station2();
			if (row != null)
			{
				if(row["AreaName"]!=null)
				{
					model.AreaName=row["AreaName"].ToString();
				}
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["PointCode"]!=null)
				{
					model.PointCode=row["PointCode"].ToString();
				}
				if(row["PointCode1"]!=null)
				{
					model.PointCode1=row["PointCode1"].ToString();
				}
				if(row["PointName"]!=null)
				{
					model.PointName=row["PointName"].ToString();
				}
				if(row["PointUses"]!=null && row["PointUses"].ToString()!="")
				{
					if((row["PointUses"].ToString()=="1")||(row["PointUses"].ToString().ToLower()=="true"))
					{
						model.PointUses=true;
					}
					else
					{
						model.PointUses=false;
					}
				}
				if(row["是否运维"]!=null)
				{
					model.是否运维=row["是否运维"].ToString();
				}
				if(row["IsPatrol"]!=null && row["IsPatrol"].ToString()!="")
				{
					if((row["IsPatrol"].ToString()=="1")||(row["IsPatrol"].ToString().ToLower()=="true"))
					{
						model.IsPatrol=true;
					}
					else
					{
						model.IsPatrol=false;
					}
				}
				if(row["是否巡检"]!=null)
				{
					model.是否巡检=row["是否巡检"].ToString();
				}
				if(row["IsContract"]!=null && row["IsContract"].ToString()!="")
				{
					if((row["IsContract"].ToString()=="1")||(row["IsContract"].ToString().ToLower()=="true"))
					{
						model.IsContract=true;
					}
					else
					{
						model.IsContract=false;
					}
				}
				if(row["是否合同"]!=null)
				{
					model.是否合同=row["是否合同"].ToString();
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["OutletNo"]!=null)
				{
					model.OutletNo=row["OutletNo"].ToString();
				}
				if(row["PassTime"]!=null && row["PassTime"].ToString()!="")
				{
					model.PassTime=DateTime.Parse(row["PassTime"].ToString());
				}
				if(row["EnvirLevel"]!=null)
				{
					model.EnvirLevel=row["EnvirLevel"].ToString();
				}
				if(row["OperatedLevel"]!=null)
				{
					model.OperatedLevel=row["OperatedLevel"].ToString();
				}
				if(row["OperatedCenter"]!=null)
				{
					model.OperatedCenter=row["OperatedCenter"].ToString();
				}
				if(row["OperatedGroup"]!=null)
				{
					model.OperatedGroup=row["OperatedGroup"].ToString();
				}
				if(row["Director"]!=null)
				{
					model.Director=row["Director"].ToString();
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
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["AreaCode"]!=null)
				{
					model.AreaCode=row["AreaCode"].ToString();
				}
				if(row["PointCodeB"]!=null)
				{
					model.PointCodeB=row["PointCodeB"].ToString();
				}
				if(row["frequency"]!=null && row["frequency"].ToString()!="")
				{
					model.frequency=int.Parse(row["frequency"].ToString());
				}
				if(row["latitude"]!=null)
				{
					model.latitude=row["latitude"].ToString();
				}
				if(row["Longitude"]!=null)
				{
					model.Longitude=row["Longitude"].ToString();
				}
				if(row["Pointaddress"]!=null)
				{
					model.Pointaddress=row["Pointaddress"].ToString();
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
			strSql.Append("select AreaName,CompanyCode,CompanyName,PointCode,PointCode1,PointName,PointUses,是否运维,IsPatrol,是否巡检,IsContract,是否合同,PointType,Name,OutletNo,PassTime,EnvirLevel,OperatedLevel,OperatedCenter,OperatedGroup,Director,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,CompanyID,PointID,AreaCode,PointCodeB,frequency,latitude,Longitude,Pointaddress ");
			strSql.Append(" FROM V_Station2 ");
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
			strSql.Append(" AreaName,CompanyCode,CompanyName,PointCode,PointCode1,PointName,PointUses,是否运维,IsPatrol,是否巡检,IsContract,是否合同,PointType,Name,OutletNo,PassTime,EnvirLevel,OperatedLevel,OperatedCenter,OperatedGroup,Director,MnCode,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,CompanyID,PointID,AreaCode,PointCodeB,frequency,latitude,Longitude,Pointaddress ");
			strSql.Append(" FROM V_Station2 ");
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
			strSql.Append("select count(1) FROM V_Station2 ");
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
			strSql.Append(")AS Row, T.*  from V_Station2 T ");
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
			parameters[0].Value = "V_Station2";
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

