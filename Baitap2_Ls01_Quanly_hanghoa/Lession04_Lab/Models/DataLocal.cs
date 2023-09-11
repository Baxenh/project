namespace Lession04_Lab.Models
{
    ///<sumary>
    ///DataLocal: Chữa dữ liệu và các phương thức thực hiện các chức năng CRUD
    ///<sumary>
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
        {
            new People(){Id=1, Name="Devmaster", Email="Xenhit2019@gmail.com", Phone="0346697228", Address="Long Biên- Hà nội",Avatar="images/avatar/ao1.jpg",Birthday=Convert.ToDateTime("2012/09/22"), Bio="Devmaster",Gender=0},
            new People(){Id=2, Name="Devmaster", Email="Xenhit2019@gmail.com", Phone="0346697228", Address="Long Biên- Hà nội",Avatar="images/avatar/ao2.jpg",Birthday=Convert.ToDateTime("2012/09/22"), Bio="Devmaster",Gender=1},
            new People(){Id=3, Name="Devmaster", Email="Xenhit2019@gmail.com", Phone="0346697228", Address="Long Biên- Hà nội",Avatar="images/avatar/ao3.jpg",Birthday=Convert.ToDateTime("2012/09/22"), Bio="Devmaster",Gender=2},
            new People(){Id=4, Name="Devmaster", Email="Xenhit2019@gmail.com", Phone="0346697228", Address="Long Biên- Hà nội",Avatar="images/avatar/ao4.jpg",Birthday=Convert.ToDateTime("2012/09/22"), Bio="Devmaster",Gender=1},
            new People(){Id=5, Name="Devmaster", Email="Xenhit2019@gmail.com", Phone="0346697228", Address="Long Biên- Hà nội",Avatar="images/avatar/ao5.jpg",Birthday=Convert.ToDateTime("2012/09/22"), Bio="Devmaster",Gender=0},
            new People(){Id=6, Name="Devmaster", Email="Xenhit2019@gmail.com", Phone="0346697228", Address="Long Biên- Hà nội",Avatar="images/avatar/ao6.jpg",Birthday=Convert.ToDateTime("2012/09/22"), Bio="Devmaster",Gender=2 },
        };
        ///<sumary>
        ///GetPeoles: Lấy danh sách dữ liệu
        ///</sumary>
        ///<returns></returns>

        public static List<People> GetPeoples()
        { return _peoples; }

        ///<sumary>
        ///GetPeoles: Lấy đối tượng People theo Id
        ///</sumary>
        ///<param name="ID"></param>
        ///<returns>People</returns>
        public static People? GetPeopleById(int id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == id);
            return people;
        }      
    }
}
