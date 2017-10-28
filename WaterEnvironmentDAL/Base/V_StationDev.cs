/**  版本信息模板在安装目录下，可自行修改。
* V_StationDev.cs
*
* 功 能： N/A
* 类 名： V_StationDev
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:17   N/A    初版
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
	/// 数据访问类:V_StationDev
	/// </summary>
	public partial class V_StationDev
	{
		public V_StationDev()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.V_StationDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_StationDev(");
			strSql.Append("SortId,AreaName,CompanyCode,CompanyName,PointCode,PointName,Name,OperatedLevel,InstrumentID,InstrumentName,InstrumentModel,InstrumentType,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,RecordFlag,PointID)");
			strSql.Append(" values (");
			strSql.Append("@SortId,@AreaName,@CompanyCode,@CompanyName,@PointCode,@PointName,@Name,@OperatedLevel,@InstrumentID,@InstrumentName,@InstrumentModel,@InstrumentType,@InstallDate,@DevCode,@DetectionPrinciple,@RangeLow,@RangeUp,@Protocol,@TransmissionType,@DevStatus,@Remark,@RecordFlag,@PointID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SortId", SqlDbType.Int,4),
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,50),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@Name", SqlDbType.NVarChar,100),
					new SqlParameter("@OperatedLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@InstrumentID", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentName", SqlDbType.NVarChar,255),
					new SqlParameter("@InstrumentModel", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentType", SqlDbType.NVarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,50),
					new SqlParameter("@RangeLow", SqlDbType.Float,8),
					new SqlParameter("@RangeUp", SqlDbType.Float,8),
					new SqlParameter("@Protocol", SqlDbType.NVarChar,50),
					new SqlParameter("@TransmissionType", SqlDbType.NVarChar,50),
					new SqlParameter("@DevStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@PointID", SqlDbType.Int,4)};
			parameters[0].Value = model.SortId;
			parameters[1].Value = model.AreaName;
			parameters[2].Value = model.CompanyCode;
			parameters[3].Value = model.CompanyName;
			parameters[4].Value = model.PointCode;
			parameters[5].Value = model.PointName;
			parameters[6].Value = model.Name;
			parameters[7].Value = model.OperatedLevel;
			parameters[8].Value = model.InstrumentID;
			parameters[9].Value = model.InstrumentName;
			parameters[10].Value = model.InstrumentModel;
			parameters[11].Value = model.InstrumentType;
			parameters[12].Value = model.InstallDate;
			parameters[13].Value = model.DevCode;
			parameters[14].Value = model.DetectionPrinciple;
			parameters[15].Value = model.RangeLow;
			parameters[16].Value = model.RangeUp;
			parameters[17].Value = model.Protocol;
			parameters[18].Value = model.TransmissionType;
			parameters[19].Value = model.DevStatus;
			parameters[20].Value = model.Remark;
			parameters[21].Value = model.RecordFlag;
			parameters[22].Value = model.PointID;

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
		public bool Update(Maticsoft.Model.V_StationDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_StationDev set ");
			strSql.Append("SortId=@SortId,");
			strSql.Append("AreaName=@AreaName,");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("PointCode=@PointCode,");
			strSql.Append("PointName=@PointName,");
			strSql.Append("Name=@Name,");
			strSql.Append("OperatedLevel=@OperatedLevel,");
			strSql.Append("InstrumentID=@InstrumentID,");
			strSql.Append("InstrumentName=@InstrumentName,");
			strSql.Append("InstrumentModel=@InstrumentModel,");
			strSql.Append("InstrumentType=@InstrumentType,");
			strSql.Append("InstallDate=@InstallDate,");
			strSql.Append("DevCode=@DevCode,");
			strSql.Append("DetectionPrinciple=@DetectionPrinciple,");
			strSql.Append("RangeLow=@RangeLow,");
			strSql.Append("RangeUp=@RangeUp,");
			strSql.Append("Protocol=@Protocol,");
			strSql.Append("TransmissionType=@TransmissionType,");
			strSql.Append("DevStatus=@DevStatus,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("RecordFlag=@RecordFlag,");
			strSql.Append("PointID=@PointID");
			strSql.Append(" where StationDevID=@StationDevID");
			SqlParameter[] parameters = {
					new SqlParameter("@SortId", SqlDbType.Int,4),
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,50),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@Name", SqlDbType.NVarChar,100),
					new SqlParameter("@OperatedLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@InstrumentID", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentName", SqlDbType.NVarChar,255),
					new SqlParameter("@InstrumentModel", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentType", SqlDbType.NVarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,50),
					new SqlParameter("@RangeLow", SqlDbType.Float,8),
					new SqlParameter("@RangeUp", SqlDbType.Float,8),
					new SqlParameter("@Protocol", SqlDbType.NVarChar,50),
					new SqlParameter("@TransmissionType", SqlDbType.NVarChar,50),
					new SqlParameter("@DevStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@StationDevID", SqlDbType.Int,4)};
			parameters[0].Value = model.SortId;
			parameters[1].Value = model.AreaName;
			parameters[2].Value = model.CompanyCode;
			parameters[3].Value = model.CompanyName;
			parameters[4].Value = model.PointCode;
			parameters[5].Value = model.PointName;
			parameters[6].Value = model.Name;
			parameters[7].Value = model.OperatedLevel;
			parameters[8].Value = model.InstrumentID;
			parameters[9].Value = model.InstrumentName;
			parameters[10].Value = model.InstrumentModel;
			parameters[11].Value = model.InstrumentType;
			parameters[12].Value = model.InstallDate;
			parameters[13].Value = model.DevCode;
			parameters[14].Value = model.DetectionPrinciple;
			parameters[15].Value = model.RangeLow;
			parameters[16].Value = model.RangeUp;
			parameters[17].Value = model.Protocol;
			parameters[18].Value = model.TransmissionType;
			parameters[19].Value = model.DevStatus;
			parameters[20].Value = model.Remark;
			parameters[21].Value = model.RecordFlag;
			parameters[22].Value = model.PointID;
			parameters[23].Value = model.StationDevID;

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
		public bool Delete(int StationDevID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from V_StationDev ");
			strSql.Append(" where StationDevID=@StationDevID");
			SqlParameter[] parameters = {
					new SqlParameter("@StationDevID", SqlDbType.Int,4)
			};
			parameters[0].Value = StationDevID;

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
		public bool DeleteList(string StationDevIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from V_StationDev ");
			strSql.Append(" where StationDevID in ("+StationDevIDlist + ")  ");
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
		public Maticsoft.Model.V_StationDev GetModel(int StationDevID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SortId,AreaName,CompanyCode,CompanyName,PointCode,PointName,Name,OperatedLevel,InstrumentID,InstrumentName,InstrumentModel,InstrumentType,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,StationDevID,RecordFlag,PointID from V_StationDev ");
			strSql.Append(" where StationDevID=@StationDevID");
			SqlParameter[] parameters = {
					new SqlParameter("@StationDevID", SqlDbType.Int,4)
			};
			parameters[0].Value = StationDevID;

			Maticsoft.Model.V_StationDev model=new Maticsoft.Model.V_StationDev();
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
		public Maticsoft.Model.V_StationDev DataRowToModel(DataRow row)
		{
			Maticsoft.Model.V_StationDev model=new Maticsoft.Model.V_StationDev();
			if (row != null)
			{
				if(row["SortId"]!=null && row["SortId"].ToString()!="")
				{
					model.SortId=int.Parse(row["SortId"].ToString());
				}
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
				if(row["PointName"]!=null)
				{
					model.PointName=row["PointName"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["OperatedLevel"]!=null)
				{
					model.OperatedLevel=row["OperatedLevel"].ToString();
				}
				if(row["InstrumentID"]!=null)
				{
					model.InstrumentID=row["InstrumentID"].ToString();
				}
				if(row["InstrumentName"]!=null)
				{
					model.InstrumentName=row["InstrumentName"].ToString();
				}
				if(row["InstrumentModel"]!=null)
				{
					model.InstrumentModel=row["InstrumentModel"].ToString();
				}
				if(row["InstrumentType"]!=null)
				{
					model.InstrumentType=row["InstrumentType"].ToString();
				}
				if(row["InstallDate"]!=null && row["InstallDate"].ToString()!="")
				{
					model.InstallDate=DateTime.Parse(row["InstallDate"].ToString());
				}
				if(row["DevCode"]!=null)
				{
					model.DevCode=row["DevCode"].ToString();
				}
				if(row["DetectionPrinciple"]!=null)
				{
					model.DetectionPrinciple=row["DetectionPrinciple"].ToString();
				}
				if(row["RangeLow"]!=null && row["RangeLow"].ToString()!="")
				{
					model.RangeLow=decimal.Parse(row["RangeLow"].ToString());
				}
				if(row["RangeUp"]!=null && row["RangeUp"].ToString()!="")
				{
					model.RangeUp=decimal.Parse(row["RangeUp"].ToString());
				}
				if(row["Protocol"]!=null)
				{
					model.Protocol=row["Protocol"].ToString();
				}
				if(row["TransmissionType"]!=null)
				{
					model.TransmissionType=row["TransmissionType"].ToString();
				}
				if(row["DevStatus"]!=null)
				{
					model.DevStatus=row["DevStatus"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["StationDevID"]!=null && row["StationDevID"].ToString()!="")
				{
					model.StationDevID=int.Parse(row["StationDevID"].ToString());
				}
				if(row["RecordFlag"]!=null)
				{
					model.RecordFlag=row["RecordFlag"].ToString();
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
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
			strSql.Append("select SortId,AreaName,CompanyCode,CompanyName,PointCode,PointName,Name,OperatedLevel,InstrumentID,InstrumentName,InstrumentModel,InstrumentType,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,StationDevID,RecordFlag,PointID ");
			strSql.Append(" FROM V_StationDev ");
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
			strSql.Append(" SortId,AreaName,CompanyCode,CompanyName,PointCode,PointName,Name,OperatedLevel,InstrumentID,InstrumentName,InstrumentModel,InstrumentType,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,StationDevID,RecordFlag,PointID ");
			strSql.Append(" FROM V_StationDev ");
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
			strSql.Append("select count(1) FROM V_StationDev ");
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
			strSql.Append(")AS Row, T.*  from V_StationDev T ");
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
			parameters[0].Value = "V_StationDev";
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

