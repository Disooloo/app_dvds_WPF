# DvDs

![](https://github.com/Disooloo/app_dvds_WPF/blob/main/info/2022-06-12_14-09-57.png?raw=true)
![](https://github.com/Disooloo/app_dvds_WPF/blob/main/info/photo_2022-06-12_14-10-50.jpg?raw=true)
![](https://github.com/Disooloo/app_dvds_WPF/blob/main/info/2022-06-12-14-06-59.gif?raw=true)


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
