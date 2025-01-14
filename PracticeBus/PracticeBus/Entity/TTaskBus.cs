//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace PracticeBus.Entity {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "t_task_bus")]
	public partial class TTaskBus {

		/// <summary>
		/// 适用机型key
		/// </summary>
		[JsonProperty, Column(Name = "airplane_type_key", DbType = "varchar(20)")]
		public string AirplaneTypeKey { get; set; } = string.Empty;

		/// <summary>
		/// 适用机型value
		/// </summary>
		[JsonProperty, Column(Name = "airplane_type_value", DbType = "varchar(50)")]
		public string AirplaneTypeValue { get; set; } = string.Empty;

		/// <summary>
		/// 课时
		/// </summary>
		[JsonProperty, Column(Name = "class_hour")]
		public int? ClassHour { get; set; }

		/// <summary>
		/// 创建人id
		/// </summary>
		[JsonProperty, Column(Name = "creator_id")]
		public long? CreatorId { get; set; }

		/// <summary>
		/// 创建人名
		/// </summary>
		[JsonProperty, Column(Name = "creator_name")]
		public string CreatorName { get; set; } = string.Empty;

		/// <summary>
		/// 逻辑删除
		/// </summary>
		[JsonProperty, Column(Name = "delete_flag")]
		public sbyte DeleteFlag { get; set; }

		/// <summary>
		/// 主键
		/// </summary>
		[JsonProperty, Column(Name = "id", IsIdentity = true)]
		public long Id { get; set; }

		/// <summary>
		/// 级别等级key
		/// </summary>
		[JsonProperty, Column(Name = "level_key", DbType = "varchar(20)")]
		public string LevelKey { get; set; } = string.Empty;

		/// <summary>
		/// 级别等级value
		/// </summary>
		[JsonProperty, Column(Name = "level_value", DbType = "varchar(50)")]
		public string LevelValue { get; set; } = string.Empty;

		/// <summary>
		/// 资源库的id
		/// </summary>
		[JsonProperty, Column(Name = "original_id")]
		public long OriginalId { get; set; }

		/// <summary>
		/// 培训计划id
		/// </summary>
		[JsonProperty, Column(Name = "plan_id")]
		public long? PlanId { get; set; }

		/// <summary>
		/// 创建时间
		/// </summary>
		[JsonProperty, Column(Name = "t_create",ServerTime = DateTimeKind.Local,CanUpdate = false)]
		public DateTime TCreate { get; set; }

		/// <summary>
		/// 修改时间
		/// </summary>
		[JsonProperty, Column(Name = "t_modified", ServerTime = DateTimeKind.Local)]
		public DateTime? TModified { get; set; }

		/// <summary>
		/// 标签显示
		/// </summary>
		[JsonProperty, Column(Name = "tag_display")]
		public string TagDisplay { get; set; } = string.Empty;

		/// <summary>
		/// 任务描述
		/// </summary>
		[JsonProperty, Column(Name = "task_desc", DbType = "text")]
		public string TaskDesc { get; set; } = string.Empty;

		/// <summary>
		/// 任务名称
		/// </summary>
		[JsonProperty, Column(Name = "task_name", DbType = "varchar(200)")]
		public string TaskName { get; set; } = string.Empty;

		/// <summary>
		/// 任务类别key
		/// </summary>
		[JsonProperty, Column(Name = "task_type_key", DbType = "varchar(20)")]
		public string TaskTypeKey { get; set; } = string.Empty;

		/// <summary>
		/// 任务类别value
		/// </summary>
		[JsonProperty, Column(Name = "task_type_value", DbType = "varchar(50)")]
		public string TaskTypeValue { get; set; } = string.Empty;

		/// <summary>
		/// 类别等级key
		/// </summary>
		[JsonProperty, Column(Name = "type_level_key", DbType = "varchar(20)")]
		public string TypeLevelKey { get; set; } = string.Empty;

		/// <summary>
		/// 类别等级value
		/// </summary>
		[JsonProperty, Column(Name = "type_level_value", DbType = "varchar(50)")]
		public string TypeLevelValue { get; set; } = string.Empty;

	}

}
