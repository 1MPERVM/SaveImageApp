using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ImageSaveApp.DataBase
{
    [Table("Images")]
    internal class Image
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
