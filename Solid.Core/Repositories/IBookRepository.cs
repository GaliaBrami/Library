﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities;

namespace Solid.Core.Repositories
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();

    }
}
