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

	/// <summary>
	/// 培训计划与课程、训练任务关系表
	/// </summary>
	[JsonObject(MemberSerialization.OptIn), Table(Name = "t_plan_course_task_exam_ref")]
	public partial class TPlanCourseTaskExamRef {

		/// <summary>
		/// 学员学习平均时长(单位：秒)
		/// </summary>
		[JsonProperty, Column(Name = "avg_learningtime")]
		public int? AvgLearningtime { get; set; }

		/// <summary>
		/// 课程id，任务id,，考试id
		/// </summary>
		[JsonProperty, Column(Name = "content_id")]
		public long? ContentId { get; set; }

		/// <summary>
		/// 内容排序
		/// </summary>
		[JsonProperty, Column(Name = "content_sort")]
		public int? ContentSort { get; set; }

		/// <summary>
		/// 创建人
		/// </summary>
		[JsonProperty, Column(Name = "create_by")]
		public long? CreateBy { get; set; }

		/// <summary>
		/// 创建时间
		/// </summary>
		[JsonProperty, Column(Name = "create_time", DbType = "datetime", ServerTime = DateTimeKind.Local, CanUpdate = false)]
		public DateTime? CreateTime { get; set; }

		/// <summary>
		/// 删除标识
		/// </summary>
		[JsonProperty, Column(Name = "delete_flag", DbType = "tinyint(2)")]
		public sbyte? DeleteFlag { get; set; }

		/// <summary>
		/// 1:课程，2:训练任务，3:考试名称
		/// </summary>
		[JsonProperty, Column(Name = "dif", DbType = "varchar(5)")]
		public string Dif { get; set; } = string.Empty;

		/// <summary>
		/// 课程学习完成率
		/// </summary>
		[JsonProperty, Column(Name = "finish_rate", DbType = "decimal(5,2)")]
		public decimal? FinishRate { get; set; }

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty, Column(Name = "id", IsIdentity = true)]
		public long Id { get; set; }

		/// <summary>
		/// 培训计划ID
		/// </summary>
		[JsonProperty, Column(Name = "plan_id")]
		public long? PlanId { get; set; }

		/// <summary>
		/// 教员名称
		/// </summary>
		[JsonProperty, Column(Name = "teacher_name", DbType = "varchar(50)")]
		public string TeacherName { get; set; } = string.Empty;

		/// <summary>
		/// 教员用户名
		/// </summary>
		[JsonProperty, Column(Name = "teacher_num", DbType = "varchar(50)")]
		public string TeacherNum { get; set; } = string.Empty;

		/// <summary>
		/// 修改时间
		/// </summary>
		[JsonProperty, Column(Name = "update_time", DbType = "datetime", ServerTime = DateTimeKind.Local)]
		public DateTime? UpdateTime { get; set; }

	}

}
