using System;

namespace Lession04_Product_tulam.Models
{
    public class DataLocal
    {
        List<SanPham> _sanphams = new List<SanPham>()
            {
                new SanPham(){ Id = 1,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
                new SanPham(){ Id = 2,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
                new SanPham(){ Id = 3,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
                new SanPham(){ Id = 4,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
                new SanPham(){ Id = 5,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
                new SanPham(){ Id = 6,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
                new SanPham(){ Id = 7,Name="Xenh",Price=379.99,SalePrice=399.00,Status=true, Image="Avatar/bag2.jpg", CreateDate= new DateTime(1985,12,07),CategoryId=1,Description="Devmaster"},
             };
        public static List<SanPham> GetSanPhams()
        {
            return _sanphams;

        }
    }
}
