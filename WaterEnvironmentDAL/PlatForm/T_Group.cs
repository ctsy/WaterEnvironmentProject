/**  版本信息模板在安装目录下，可自行修改。
* T_Group.cs
*
* 功 能： N/A
* 类 名： T_Group
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:27:12   N/A    初版
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
	/// 数据访问类:T_Group
	/// </summary>
	public partial class T_Group
	{
		public T_Group()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbPlatFormBaseHelperSQL.GetMaxID("ID", "T_Group"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Group");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbPlatFormBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Group(");
			strSql.Append("GroupName,AddMember,Role,Variable,deletable)");
			strSql.Append(" values (");
			strSql.Append("@GroupName,@AddMember,@Role,@Variable,@deletable)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupName", SqlDbType.NVarChar,200),
					new SqlParameter("@AddMember", SqlDbType.Bit,1),
					new SqlParameter("@Role", SqlDbType.NVarChar,500),
					new SqlParameter("@Variable", SqlDbType.Bit,1),
					new SqlParameter("@deletable", SqlDbType.Bit,1)};
			parameters[0].Value = model.GroupName;
			parameters[1].Value = model.AddMember;
			parameters[2].Value = model.Role;
			parameters[3].Value = model.Variable;
			parameters[4].Value = model.deletable;

			object obj = DbPlatFormBaseHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.T_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Group set ");
			strSql.Append("GroupName=@GroupName,");
			strSql.Append("AddMember=@AddMember,");
			strSql.Append("Role=@Role,");
			strSql.Append("Variable=@Variable,");
			strSql.Append("deletable=@deletable");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupName", SqlDbType.NVarChar,200),
					new SqlParameter("@AddMember", SqlDbType.Bit,1),
					new SqlParameter("@Role", SqlDbType.NVarChar,500),
					new SqlParameter("@Variable", SqlDbType.Bit,1),
					new SqlParameter("@deletable", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupName;
			parameters[1].Value = model.AddMember;
			parameters[2].Value = model.Role;
			parameters[3].Value = model.Variable;
			parameters[4].Value = model.deletable;
			parameters[5].Value = model.ID;

			int rows=DbPlatFormBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Group ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbPlatFormBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Group ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbPlatFormBaseHelperSQL.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.T_Group GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GroupName,AddMember,Role,Variable,deletable from T_Group ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.T_Group model=new Maticsoft.Model.T_Group();
			DataSet ds=DbPlatFormBaseHelperSQL.Query(strSql.ToString(),parameters);
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
		public Maticsoft.Model.T_Group DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Group model=new Maticsoft.Model.T_Group();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GroupName"]!=null)
				{
					model.GroupName=row["GroupName"].ToString();
				}
				if(row["AddMember"]!=null && row["AddMember"].ToString()!="")
				{
					if((row["AddMember"].ToString()=="1")||(row["AddMember"].ToString().ToLower()=="true"))
					{
						model.AddMember=true;
					}
					else
					{
						model.AddMember=false;
					}
				}
				if(row["Role"]!=null)
				{
					model.Role=row["Role"].ToString();
				}
				if(row["Variable"]!=null && row["Variable"].ToString()!="")
				{
					if((row["Variable"].ToString()=="1")||(row["Variable"].ToString().ToLower()=="true"))
					{
						model.Variable=true;
					}
					else
					{
						model.Variable=false;
					}
				}
				if(row["deletable"]!=null && row["deletable"].ToString()!="")
				{
					if((row["deletable"].ToString()=="1")||(row["deletable"].ToString().ToLower()=="true"))
					{
						model.deletable=true;
					}
					else
					{
						model.deletable=false;
					}
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
			strSql.Append("select ID,GroupName,AddMember,Role,Variable,deletable ");
			strSql.Append(" FROM T_Group ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbPlatFormBaseHelperSQL.Query(strSql.ToString());
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
			strSql.Append(" ID,GroupName,AddMember,Role,Variable,deletable ");
			strSql.Append(" FROM T_Group ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbPlatFormBaseHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_Group ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Group T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbPlatFormBaseHelperSQL.Query(strSql.ToString());
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
			parameters[0].Value = "T_Group";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbPlatFormBaseHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

