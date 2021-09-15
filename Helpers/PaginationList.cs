using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroXTeam.DTOs;

namespace ZeroXTeam.Helpers
{
    public class PaginationList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int ItemPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public string SortBy { get; set; }
        public PaginationList(List<T> items, int currentPage, int itemPerPage, int totalItems, string sortBy)
        {
            AddRange(items);
            CurrentPage = currentPage;
            ItemPerPage = itemPerPage;
            TotalItems = totalItems;
            SortBy = sortBy;
            TotalPages = (int)Math.Ceiling((double)((double)totalItems / (double)itemPerPage));
        }

    public static async Task<PaginationList<T>> CreatePagination(IQueryable<T> query, PaginationParams paginationParams)
        {
            var totalCounts = await query.CountAsync();
            var items = await query
                .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemPerPage)
                .Take(paginationParams.ItemPerPage)
                .ToListAsync();
                
            return new PaginationList<T>(
                items, 
                paginationParams.PageNumber, 
                paginationParams.ItemPerPage, 
                totalCounts,
                paginationParams.SortBy
            );
        } 
    }
}