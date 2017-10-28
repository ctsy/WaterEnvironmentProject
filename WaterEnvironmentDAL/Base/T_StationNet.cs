/**  版本信息模板在安装目录下，可自行修改。
* T_StationNet.cs
*
* 功 能： N/A
* 类 名： T_StationNet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:56   N/A    初版
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
	/// 数据访问类:T_StationNet
	/// </summary>
	public partial class T_StationNet
	{
		public T_StationNet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbBaseHelperSQL.GetMaxID("PointID", "T_StationNet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PointID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_StationNet");
			strSql.Append(" where PointID=@PointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4)			};
			parameters[0].Value = PointID;

			return DbBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_StationNet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_StationNet(");
			strSql.Append("PointID,RouterIP,RouterPort,RounterUser,RounterPws,DataIP,DataPort,DataUser,DataPws,VedioIP,VideoPort,VidioID,VideoUser,VideoPws,LineNo,Vlan,NetOperator,NetType,PW,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG)");
			strSql.Append(" values (");
			strSql.Append("@PointID,@RouterIP,@RouterPort,@RounterUser,@RounterPws,@DataIP,@DataPort,@DataUser,@DataPws,@VedioIP,@VideoPort,@VidioID,@VideoUser,@VideoPws,@LineNo,@Vlan,@NetOperator,@NetType,@PW,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG)");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@RouterIP", SqlDbType.NVarChar,50),
					new SqlParameter("@RouterPort", SqlDbType.NVarChar,50),
					new SqlParameter("@RounterUser", SqlDbType.NVarChar,50),
					new SqlParameter("@RounterPws", SqlDbType.NVarChar,50),
					new SqlParameter("@DataIP", SqlDbType.NVarChar,50),
					new SqlParameter("@DataPort", SqlDbType.NVarChar,50),
					new SqlParameter("@DataUser", SqlDbType.NVarChar,50),
					new SqlParameter("@DataPws", SqlDbType.NVarChar,50),
					new SqlParameter("@VedioIP", SqlDbType.NVarChar,50),
					new SqlParameter("@VideoPort", SqlDbType.NVarChar,50),
					new SqlParameter("@VidioID", SqlDbType.NVarChar,50),
					new SqlParameter("@VideoUser", SqlDbType.NVarChar,50),
					new SqlParameter("@VideoPws", SqlDbType.NVarChar,50),
					new SqlParameter("@LineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Vlan", SqlDbType.NVarChar,50),
					new SqlParameter("@NetOperator", SqlDbType.NVarChar,50),
					new SqlParameter("@NetType", SqlDbType.NVarChar,50),
					new SqlParameter("@PW", SqlDbType.NVarChar,25),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4)};
			parameters[0].Value = model.PointID;
			parameters[1].Value = model.RouterIP;
			parameters[2].Value = model.RouterPort;
			parameters[3].Value = model.RounterUser;
			parameters[4].Value = model.RounterPws;
			parameters[5].Value = model.DataIP;
			parameters[6].Value = model.DataPort;
			parameters[7].Value = model.DataUser;
			parameters[8].Value = model.DataPws;
			parameters[9].Value = model.VedioIP;
			parameters[10].Value = model.VideoPort;
			parameters[11].Value = model.VidioID;
			parameters[12].Value = model.VideoUser;
			parameters[13].Value = model.VideoPws;
			parameters[14].Value = model.LineNo;
			parameters[15].Value = model.Vlan;
			parameters[16].Value = model.NetOperator;
			parameters[17].Value = model.NetType;
			parameters[18].Value = model.PW;
			parameters[19].Value = model.ExcelServerRCID;
			parameters[20].Value = model.ExcelServerRN;
			parameters[21].Value = model.ExcelServerCN;
			parameters[22].Value = model.ExcelServerRC1;
			parameters[23].Value = model.ExcelServerWIID;
			parameters[24].Value = model.ExcelServerRTID;
			parameters[25].Value = model.ExcelServerCHG;

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
		public bool Update(Maticsoft.Model.T_StationNet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_StationNet set ");
			strSql.Append("RouterIP=@RouterIP,");
			strSql.Append("RouterPort=@RouterPort,");
			strSql.Append("RounterUser=@RounterUser,");
			strSql.Append("RounterPws=@RounterPws,");
			strSql.Append("DataIP=@DataIP,");
			strSql.Append("DataPort=@DataPort,");
			strSql.Append("DataUser=@DataUser,");
			strSql.Append("DataPws=@DataPws,");
			strSql.Append("VedioIP=@VedioIP,");
			strSql.Append("VideoPort=@VideoPort,");
			strSql.Append("VidioID=@VidioID,");
			strSql.Append("VideoUser=@VideoUser,");
			strSql.Append("VideoPws=@VideoPws,");
			strSql.Append("LineNo=@LineNo,");
			strSql.Append("Vlan=@Vlan,");
			strSql.Append("NetOperator=@NetOperator,");
			strSql.Append("NetType=@NetType,");
			strSql.Append("PW=@PW,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG");
			strSql.Append(" where PointID=@PointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RouterIP", SqlDbType.NVarChar,50),
					new SqlParameter("@RouterPort", SqlDbType.NVarChar,50),
					new SqlParameter("@RounterUser", SqlDbType.NVarChar,50),
					new SqlParameter("@RounterPws", SqlDbType.NVarChar,50),
					new SqlParameter("@DataIP", SqlDbType.NVarChar,50),
					new SqlParameter("@DataPort", SqlDbType.NVarChar,50),
					new SqlParameter("@DataUser", SqlDbType.NVarChar,50),
					new SqlParameter("@DataPws", SqlDbType.NVarChar,50),
					new SqlParameter("@VedioIP", SqlDbType.NVarChar,50),
					new SqlParameter("@VideoPort", SqlDbType.NVarChar,50),
					new SqlParameter("@VidioID", SqlDbType.NVarChar,50),
					new SqlParameter("@VideoUser", SqlDbType.NVarChar,50),
					new SqlParameter("@VideoPws", SqlDbType.NVarChar,50),
					new SqlParameter("@LineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Vlan", SqlDbType.NVarChar,50),
					new SqlParameter("@NetOperator", SqlDbType.NVarChar,50),
					new SqlParameter("@NetType", SqlDbType.NVarChar,50),
					new SqlParameter("@PW", SqlDbType.NVarChar,25),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4)};
			parameters[0].Value = model.RouterIP;
			parameters[1].Value = model.RouterPort;
			parameters[2].Value = model.RounterUser;
			parameters[3].Value = model.RounterPws;
			parameters[4].Value = model.DataIP;
			parameters[5].Value = model.DataPort;
			parameters[6].Value = model.DataUser;
			parameters[7].Value = model.DataPws;
			parameters[8].Value = model.VedioIP;
			parameters[9].Value = model.VideoPort;
			parameters[10].Value = model.VidioID;
			parameters[11].Value = model.VideoUser;
			parameters[12].Value = model.VideoPws;
			parameters[13].Value = model.LineNo;
			parameters[14].Value = model.Vlan;
			parameters[15].Value = model.NetOperator;
			parameters[16].Value = model.NetType;
			parameters[17].Value = model.PW;
			parameters[18].Value = model.ExcelServerRCID;
			parameters[19].Value = model.ExcelServerRN;
			parameters[20].Value = model.ExcelServerCN;
			parameters[21].Value = model.ExcelServerRC1;
			parameters[22].Value = model.ExcelServerWIID;
			parameters[23].Value = model.ExcelServerRTID;
			parameters[24].Value = model.ExcelServerCHG;
			parameters[25].Value = model.PointID;

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
			strSql.Append("delete from T_StationNet ");
			strSql.Append(" where PointID=@PointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4)			};
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string PointIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_StationNet ");
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
		public Maticsoft.Model.T_StationNet GetModel(int PointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PointID,RouterIP,RouterPort,RounterUser,RounterPws,DataIP,DataPort,DataUser,DataPws,VedioIP,VideoPort,VidioID,VideoUser,VideoPws,LineNo,Vlan,NetOperator,NetType,PW,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG from T_StationNet ");
			strSql.Append(" where PointID=@PointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4)			};
			parameters[0].Value = PointID;

			Maticsoft.Model.T_StationNet model=new Maticsoft.Model.T_StationNet();
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
		public Maticsoft.Model.T_StationNet DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_StationNet model=new Maticsoft.Model.T_StationNet();
			if (row != null)
			{
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["RouterIP"]!=null)
				{
					model.RouterIP=row["RouterIP"].ToString();
				}
				if(row["RouterPort"]!=null)
				{
					model.RouterPort=row["RouterPort"].ToString();
				}
				if(row["RounterUser"]!=null)
				{
					model.RounterUser=row["RounterUser"].ToString();
				}
				if(row["RounterPws"]!=null)
				{
					model.RounterPws=row["RounterPws"].ToString();
				}
				if(row["DataIP"]!=null)
				{
					model.DataIP=row["DataIP"].ToString();
				}
				if(row["DataPort"]!=null)
				{
					model.DataPort=row["DataPort"].ToString();
				}
				if(row["DataUser"]!=null)
				{
					model.DataUser=row["DataUser"].ToString();
				}
				if(row["DataPws"]!=null)
				{
					model.DataPws=row["DataPws"].ToString();
				}
				if(row["VedioIP"]!=null)
				{
					model.VedioIP=row["VedioIP"].ToString();
				}
				if(row["VideoPort"]!=null)
				{
					model.VideoPort=row["VideoPort"].ToString();
				}
				if(row["VidioID"]!=null)
				{
					model.VidioID=row["VidioID"].ToString();
				}
				if(row["VideoUser"]!=null)
				{
					model.VideoUser=row["VideoUser"].ToString();
				}
				if(row["VideoPws"]!=null)
				{
					model.VideoPws=row["VideoPws"].ToString();
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
				if(row["PW"]!=null)
				{
					model.PW=row["PW"].ToString();
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
			strSql.Append("select PointID,RouterIP,RouterPort,RounterUser,RounterPws,DataIP,DataPort,DataUser,DataPws,VedioIP,VideoPort,VidioID,VideoUser,VideoPws,LineNo,Vlan,NetOperator,NetType,PW,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_StationNet ");
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
			strSql.Append(" PointID,RouterIP,RouterPort,RounterUser,RounterPws,DataIP,DataPort,DataUser,DataPws,VedioIP,VideoPort,VidioID,VideoUser,VideoPws,LineNo,Vlan,NetOperator,NetType,PW,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_StationNet ");
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
			strSql.Append("select count(1) FROM T_StationNet ");
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
			strSql.Append(")AS Row, T.*  from T_StationNet T ");
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
			parameters[0].Value = "T_StationNet";
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

