using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyTemplate.DAL.Entities.Base
{
	/// <summary>
	/// 基礎 Entity Base Class，擁有新增、修改、刪除等基礎屬性
	/// </summary>
	public class BaseEntity
    {
		/// <summary>
		/// 屬性 Id 設定成 Primary Key 且自動遞增
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("SeqId")]
		public long Id { get; set; }

		/// <summary>
		/// 建立時間
		/// </summary>
		/// 
		[Column("CreateDate")]
		public DateTime CreationTime { get; set; } = DateTime.Now;

		/// <summary>
		/// 建立使用者代碼
		/// </summary>
		[Required]
		[MaxLength(100)]
		public string CreateUser { get; set; } = "System";

		/// <summary>
		/// 更新時間
		/// </summary>
		[Column("ModifyDate")]
		public DateTime? LastModificationTime { get; set; } = DateTime.Now;

		/// <summary>
		/// 更新使用者代碼
		/// </summary>
		[MaxLength(100)]
		public string ModifyUser { get; set; }

		/// <summary>
		/// 刪除時間
		/// </summary>
		[Column("DeleteDate")]
		public DateTime? DeletionTime { get; set; }

		/// <summary>
		/// 刪除使用者代碼
		/// </summary>
		[MaxLength(100)]
		public string DeleteUser { get; set; }

		/// <summary>
		/// 是否刪除
		/// </summary>
		[Column("DeleteFlag")]
		public bool IsDeleted { get; set; }
	}
}
