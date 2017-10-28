/**  版本信息模板在安装目录下，可自行修改。
* T_StationInformation.cs
*
* 功 能： N/A
* 类 名： T_StationInformation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:54   N/A    初版
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
	/// 数据访问类:T_StationInformation
	/// </summary>
	public partial class T_StationInformation
	{
		public T_StationInformation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PointCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_StationInformation");
			strSql.Append(" where PointCode=@PointCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20)			};
			parameters[0].Value = PointCode;

			return DbBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_StationInformation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_StationInformation(");
			strSql.Append("CompanyCode,PointCode,PointName,PointUses,PointType,OperatedLevel,OperatedCenter,OperatedGroup,Director,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,MnCode,OutletNo,PassTime,PointCode1,EnvirLevel,IsPatrol,IsContract,CompanyID,Longitude,latitude,frequency,Pointaddress,PointCodeB,Controlsystem,Treatmentprocess)");
			strSql.Append(" values (");
			strSql.Append("@CompanyCode,@PointCode,@PointName,@PointUses,@PointType,@OperatedLevel,@OperatedCenter,@OperatedGroup,@Director,@RouterIP,@DataIP,@VedioIP,@LineNo,@Vlan,@NetOperator,@NetType,@remark,@UpdateTime,@UpdatePerson,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@MnCode,@OutletNo,@PassTime,@PointCode1,@EnvirLevel,@IsPatrol,@IsContract,@CompanyID,@Longitude,@latitude,@frequency,@Pointaddress,@PointCodeB,@Controlsystem,@Treatmentprocess)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointUses", SqlDbType.Bit,1),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@OperatedLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedCenter", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedGroup", SqlDbType.NVarChar,20),
					new SqlParameter("@Director", SqlDbType.NVarChar,50),
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
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@OutletNo", SqlDbType.NVarChar,20),
					new SqlParameter("@PassTime", SqlDbType.DateTime),
					new SqlParameter("@PointCode1", SqlDbType.NVarChar,20),
					new SqlParameter("@EnvirLevel", SqlDbType.NVarChar,50),
					new SqlParameter("@IsPatrol", SqlDbType.Bit,1),
					new SqlParameter("@IsContract", SqlDbType.Bit,1),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@Longitude", SqlDbType.NVarChar,50),
					new SqlParameter("@latitude", SqlDbType.NVarChar,50),
					new SqlParameter("@frequency", SqlDbType.Int,4),
					new SqlParameter("@Pointaddress", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCodeB", SqlDbType.NVarChar,50),
					new SqlParameter("@Controlsystem", SqlDbType.NVarChar,50),
					new SqlParameter("@Treatmentprocess", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.PointCode;
			parameters[2].Value = model.PointName;
			parameters[3].Value = model.PointUses;
			parameters[4].Value = model.PointType;
			parameters[5].Value = model.OperatedLevel;
			parameters[6].Value = model.OperatedCenter;
			parameters[7].Value = model.OperatedGroup;
			parameters[8].Value = model.Director;
			parameters[9].Value = model.RouterIP;
			parameters[10].Value = model.DataIP;
			parameters[11].Value = model.VedioIP;
			parameters[12].Value = model.LineNo;
			parameters[13].Value = model.Vlan;
			parameters[14].Value = model.NetOperator;
			parameters[15].Value = model.NetType;
			parameters[16].Value = model.remark;
			parameters[17].Value = model.UpdateTime;
			parameters[18].Value = model.UpdatePerson;
			parameters[19].Value = model.ExcelServerRCID;
			parameters[20].Value = model.ExcelServerRN;
			parameters[21].Value = model.ExcelServerCN;
			parameters[22].Value = model.ExcelServerRC1;
			parameters[23].Value = model.ExcelServerWIID;
			parameters[24].Value = model.ExcelServerRTID;
			parameters[25].Value = model.ExcelServerCHG;
			parameters[26].Value = model.MnCode;
			parameters[27].Value = model.OutletNo;
			parameters[28].Value = model.PassTime;
			parameters[29].Value = model.PointCode1;
			parameters[30].Value = model.EnvirLevel;
			parameters[31].Value = model.IsPatrol;
			parameters[32].Value = model.IsContract;
			parameters[33].Value = model.CompanyID;
			parameters[34].Value = model.Longitude;
			parameters[35].Value = model.latitude;
			parameters[36].Value = model.frequency;
			parameters[37].Value = model.Pointaddress;
			parameters[38].Value = model.PointCodeB;
			parameters[39].Value = model.Controlsystem;
			parameters[40].Value = model.Treatmentprocess;

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
		public bool Update(Maticsoft.Model.T_StationInformation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_StationInformation set ");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("PointName=@PointName,");
			strSql.Append("PointUses=@PointUses,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("OperatedLevel=@OperatedLevel,");
			strSql.Append("OperatedCenter=@OperatedCenter,");
			strSql.Append("OperatedGroup=@OperatedGroup,");
			strSql.Append("Director=@Director,");
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
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("MnCode=@MnCode,");
			strSql.Append("OutletNo=@OutletNo,");
			strSql.Append("PassTime=@PassTime,");
			strSql.Append("PointCode1=@PointCode1,");
			strSql.Append("EnvirLevel=@EnvirLevel,");
			strSql.Append("IsPatrol=@IsPatrol,");
			strSql.Append("IsContract=@IsContract,");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("latitude=@latitude,");
			strSql.Append("frequency=@frequency,");
			strSql.Append("Pointaddress=@Pointaddress,");
			strSql.Append("PointCodeB=@PointCodeB,");
			strSql.Append("Controlsystem=@Controlsystem,");
			strSql.Append("Treatmentprocess=@Treatmentprocess");
			strSql.Append(" where PointID=@PointID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointUses", SqlDbType.Bit,1),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@OperatedLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedCenter", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatedGroup", SqlDbType.NVarChar,20),
					new SqlParameter("@Director", SqlDbType.NVarChar,50),
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
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@OutletNo", SqlDbType.NVarChar,20),
					new SqlParameter("@PassTime", SqlDbType.DateTime),
					new SqlParameter("@PointCode1", SqlDbType.NVarChar,20),
					new SqlParameter("@EnvirLevel", SqlDbType.NVarChar,50),
					new SqlParameter("@IsPatrol", SqlDbType.Bit,1),
					new SqlParameter("@IsContract", SqlDbType.Bit,1),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@Longitude", SqlDbType.NVarChar,50),
					new SqlParameter("@latitude", SqlDbType.NVarChar,50),
					new SqlParameter("@frequency", SqlDbType.Int,4),
					new SqlParameter("@Pointaddress", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCodeB", SqlDbType.NVarChar,50),
					new SqlParameter("@Controlsystem", SqlDbType.NVarChar,50),
					new SqlParameter("@Treatmentprocess", SqlDbType.NVarChar,50),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20),
					new SqlParameter("@PointID", SqlDbType.Int,4)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.PointName;
			parameters[2].Value = model.PointUses;
			parameters[3].Value = model.PointType;
			parameters[4].Value = model.OperatedLevel;
			parameters[5].Value = model.OperatedCenter;
			parameters[6].Value = model.OperatedGroup;
			parameters[7].Value = model.Director;
			parameters[8].Value = model.RouterIP;
			parameters[9].Value = model.DataIP;
			parameters[10].Value = model.VedioIP;
			parameters[11].Value = model.LineNo;
			parameters[12].Value = model.Vlan;
			parameters[13].Value = model.NetOperator;
			parameters[14].Value = model.NetType;
			parameters[15].Value = model.remark;
			parameters[16].Value = model.UpdateTime;
			parameters[17].Value = model.UpdatePerson;
			parameters[18].Value = model.ExcelServerRCID;
			parameters[19].Value = model.ExcelServerRN;
			parameters[20].Value = model.ExcelServerCN;
			parameters[21].Value = model.ExcelServerRC1;
			parameters[22].Value = model.ExcelServerWIID;
			parameters[23].Value = model.ExcelServerRTID;
			parameters[24].Value = model.ExcelServerCHG;
			parameters[25].Value = model.MnCode;
			parameters[26].Value = model.OutletNo;
			parameters[27].Value = model.PassTime;
			parameters[28].Value = model.PointCode1;
			parameters[29].Value = model.EnvirLevel;
			parameters[30].Value = model.IsPatrol;
			parameters[31].Value = model.IsContract;
			parameters[32].Value = model.CompanyID;
			parameters[33].Value = model.Longitude;
			parameters[34].Value = model.latitude;
			parameters[35].Value = model.frequency;
			parameters[36].Value = model.Pointaddress;
			parameters[37].Value = model.PointCodeB;
			parameters[38].Value = model.Controlsystem;
			parameters[39].Value = model.Treatmentprocess;
			parameters[40].Value = model.PointCode;
			parameters[41].Value = model.PointID;

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
		public bool Delete(int PointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_StationInformation ");
			strSql.Append(" where PointID=@PointID");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4)
			};
			parameters[0].Value = PointID;

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
		public bool Delete(string PointCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_StationInformation ");
			strSql.Append(" where PointCode=@PointCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20)			};
			parameters[0].Value = PointCode;

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
		public bool DeleteList(string PointIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_StationInformation ");
			strSql.Append(" where PointID in ("+PointIDlist + ")  ");
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
		public Maticsoft.Model.T_StationInformation GetModel(int PointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyCode,PointCode,PointName,PointUses,PointType,OperatedLevel,OperatedCenter,OperatedGroup,Director,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,MnCode,OutletNo,PassTime,PointCode1,EnvirLevel,IsPatrol,IsContract,CompanyID,PointID,Longitude,latitude,frequency,Pointaddress,PointCodeB,Controlsystem,Treatmentprocess from T_StationInformation ");
			strSql.Append(" where PointID=@PointID");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4)
			};
			parameters[0].Value = PointID;

			Maticsoft.Model.T_StationInformation model=new Maticsoft.Model.T_StationInformation();
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
		public Maticsoft.Model.T_StationInformation DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_StationInformation model=new Maticsoft.Model.T_StationInformation();
			if (row != null)
			{
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["PointCode"]!=null)
				{
					model.PointCode=row["PointCode"].ToString();
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
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
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
				if(row["MnCode"]!=null)
				{
					model.MnCode=row["MnCode"].ToString();
				}
				if(row["OutletNo"]!=null)
				{
					model.OutletNo=row["OutletNo"].ToString();
				}
				if(row["PassTime"]!=null && row["PassTime"].ToString()!="")
				{
					model.PassTime=DateTime.Parse(row["PassTime"].ToString());
				}
				if(row["PointCode1"]!=null)
				{
					model.PointCode1=row["PointCode1"].ToString();
				}
				if(row["EnvirLevel"]!=null)
				{
					model.EnvirLevel=row["EnvirLevel"].ToString();
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
				if(row["CompanyID"]!=null && row["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(row["CompanyID"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["Longitude"]!=null)
				{
					model.Longitude=row["Longitude"].ToString();
				}
				if(row["latitude"]!=null)
				{
					model.latitude=row["latitude"].ToString();
				}
				if(row["frequency"]!=null && row["frequency"].ToString()!="")
				{
					model.frequency=int.Parse(row["frequency"].ToString());
				}
				if(row["Pointaddress"]!=null)
				{
					model.Pointaddress=row["Pointaddress"].ToString();
				}
				if(row["PointCodeB"]!=null)
				{
					model.PointCodeB=row["PointCodeB"].ToString();
				}
				if(row["Controlsystem"]!=null)
				{
					model.Controlsystem=row["Controlsystem"].ToString();
				}
				if(row["Treatmentprocess"]!=null)
				{
					model.Treatmentprocess=row["Treatmentprocess"].ToString();
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
			strSql.Append("select CompanyCode,PointCode,PointName,PointUses,PointType,OperatedLevel,OperatedCenter,OperatedGroup,Director,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,MnCode,OutletNo,PassTime,PointCode1,EnvirLevel,IsPatrol,IsContract,CompanyID,PointID,Longitude,latitude,frequency,Pointaddress,PointCodeB,Controlsystem,Treatmentprocess ");
			strSql.Append(" FROM T_StationInformation ");
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
			strSql.Append(" CompanyCode,PointCode,PointName,PointUses,PointType,OperatedLevel,OperatedCenter,OperatedGroup,Director,RouterIP,DataIP,VedioIP,LineNo,Vlan,NetOperator,NetType,remark,UpdateTime,UpdatePerson,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,MnCode,OutletNo,PassTime,PointCode1,EnvirLevel,IsPatrol,IsContract,CompanyID,PointID,Longitude,latitude,frequency,Pointaddress,PointCodeB,Controlsystem,Treatmentprocess ");
			strSql.Append(" FROM T_StationInformation ");
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
			strSql.Append("select count(1) FROM T_StationInformation ");
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
				strSql.Append("order by T.PointID desc");
			}
			strSql.Append(")AS Row, T.*  from T_StationInformation T ");
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
			parameters[0].Value = "T_StationInformation";
			parameters[1].Value = "PointID";
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

