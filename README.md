# Hair Salon Stylist & Client Tracker

#### By [Will W.](https://wjwat.com/)

#### Implement a vendor & ord... wait, I mean a stylist & client tracker! Now with databases!

## :computer: Technologies Used

* C#
* .NET 5.0
* ASP.NET Core
* Razor
* Entity Framework Core
* MySQL
* dotnet script REPL
* HTML
* CSS | [YACCK](https://github.com/sphars/yacck)
* JQuery
* Popcorn! Aren't microwaves great?

## :memo: Description

Pierre, our lovable bakery owner, has now recommended my services to his friends. They won't be his friends for long though when I'm done with them! This project builds on our previous lessons and forgoes RESTful routing in favor of a CRUD app backed by a MySQL database.

## :gear: Setup/Installation & Usage Instructions

- [Install the MySQL Community Server & MySQL Workbench](https://dev.mysql.com/downloads/mysql/)
- [Install the .NET 5 SDK](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
- [Clone this
  repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
  to your device
- Import the SQL database located in the top level of this project
  - Using `MySQL Workbench`
    - Open `MySQL Workbench`
    - Under `Import Options` select `Import from self-contained file`.
    - Navigate to the directory where you've downloaded this repository & select `will_watkins.sql`
    - Click OK
    - Go to the tab called `Import Progress` and click `Start Import` at the bottom right
    - Reopen the `Schemas` tab under `Navigator`
    - Right click and select `Refresh All` to verify that the database `will_watkins` appears
- Create `appsettings.json` in the top level of this repo
  - Copy the contents of the code below into this file. *Make sure to change the password to the password you used to setup your MySQL server*
  ```JSON
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=<PASSWORD>;"
    }
  }
  ```
- [Using your
  terminal](https://www.freecodecamp.org/news/how-you-can-be-more-productive-right-now-using-bash-29a976fb1ab4/)
  navigate to the directory where you have cloned this repo.
- Run `dotnet build HairSalon` in the top level directory of this repo.
- Run `dotnet run --project HairSalon` to get the program running, and the site hosted locally.
- Visit `http://localhost:5000` to try the site out.
  - Please make sure to look at your terminal to determine the port number you should be visiting in your browser. It may change between runs.
  - Ex:
    ```shell
    $ dotnet run --project HairSalon
      Hosting environment: Production
      Content root path: /path/to/HairSalon.Solution/HairSalon
      Now listening on: http://localhost:5000
      Now listening on: https://localhost:5001
      Application started. Press Ctrl+C to shut down.
    ```

## :world_map: Roadmap

- Make search non-naive.
  - We look for any occurrences of the whole search string in our rows which means searching for "firstname lastname" will not return anything.
- Redirect any invalid route to a 404 page.
- Styling is getting better, but still has some pain points.
- Validation server-side could be stronger
  - Input validation can always be stronger
  - I'd like to better understand what JQuery is doing client-side as well.
- Allow user to set schedules, and track appointments
  - I looked at this but felt like it was way outside the scope of what I'm willing to spend time to do in any sort of reasonable way. Maybe I'm overestimating how hard it would be though.

## :lady_beetle: Known Bugs

* If any are found please feel free to open an issue or email me at wjwat at
  onionslice dot org

## :warning: License

MIT License

Copyright (c) 2022 Will W. (ಥ﹏ಥ)
