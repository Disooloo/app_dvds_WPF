# DvDs

!(info/2022-06-12_14-09-57.png)[]
!(info/photo_2022-06-12_14-10-50.jpg)[]

!(info/2022-06-12-14-06-59.gif)[]


> db/model1/Model1.Context.cs
```
 public static appDVDsEntities _context;

        public static appDVDsEntities GetContext()
        {
            if (_context == null)
                _context = new appDVDsEntities();
            return _context;
        }
```
