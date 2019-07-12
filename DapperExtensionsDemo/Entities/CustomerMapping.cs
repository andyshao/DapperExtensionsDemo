using DapperExtensions.Mapper;
using DapperExtensionsDemo.Entities;

namespace DapperMappingDemo.Entities
{
    public class CustomerMapping : ClassMapper<Customer>
    {
        public CustomerMapping()
        {
            // 自定义映射的表名
            Table("Customer");

            // 自定义映射表的主键
            Map(m => m.Id)
                .Key(KeyType.Identity);// 主键的类型

            // 自定义列名
            Map(x => x.LastName)
                .Column("lastname")
                .Ignore(); // 忽略LastName这一列


            // 启用自动映射，一定要调用此方法
            AutoMap();
        }
    }
}
