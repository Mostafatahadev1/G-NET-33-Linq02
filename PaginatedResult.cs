using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_Linq02
{
    public class PaginatedResult
    {

        
        public List<T> Products = new List<T>();

        public int TotalCount { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalPageNumber => (int)Math.Ceiling (TotalCount / (double) PageSize);

        public bool HasNextPage => PageNumerber < TotalPageNumber;

        public bool HasPreviousPage => PageNumerber > 1;

        public int PageNumerber { get; private set; }
    }



}