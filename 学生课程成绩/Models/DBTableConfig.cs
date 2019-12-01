using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        //实现默认接口
    
        /// <summary>
        /// 此处可以设置数据表的字段属性，定义键、索引、约束等。细节在learn EFCore文档上看
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.From).HasColumnType("varchar(100)");

        }
    }
}
