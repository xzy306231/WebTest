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
using System.Collections.Generic;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace CoursewareModifyTool.Model.Course
{

	[JsonObject(MemberSerialization.OptIn), Table(Name = "t_course_know_tag")]
	public partial class TCourseKnowTag {

		/// <summary>
		/// 课程ID
		/// </summary>
		[JsonProperty, Column(Name = "course_id")]
		public long? CourseId { get; set; }

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty, Column(Name = "id", IsIdentity = true)]
		public long Id { get; set; }

		/// <summary>
		/// 知识点ID
		/// </summary>
		[JsonProperty, Column(Name = "tag_id")]
		public long? TagId { get; set; }


		#region 外键 => 导航属性，ManyToMany

		#endregion
	}

}
