using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WpfAppSelectedItemPreviousItem.DAL.Context;
using WpfAppSelectedItemPreviousItem.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WpfAppSelectedItemPreviousItem.Data
{
    class DbInitializer
    {
        private readonly cntxDBWpfAppSelectedItemPreviousItem _db;
        private readonly ILogger<DbInitializer> _Logger;

        public DbInitializer(cntxDBWpfAppSelectedItemPreviousItem db, ILogger<DbInitializer> Logger)
        {
            _db = db;
            _Logger = Logger;
        }

        public async Task InitializeAsync()
        {
            var timer = Stopwatch.StartNew();
            _Logger.LogInformation("Инициализация БД...");

            _Logger.LogInformation("Миграция БД...");
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            _Logger.LogInformation("Миграция БД выполнена за {0} мс", timer.ElapsedMilliseconds);

            if (await _db.Deals.AnyAsync()) return;


            await InitializeDeals();

            _Logger.LogInformation("Инициализация БД выполнена за {0} с", timer.Elapsed.TotalSeconds);
        }


        private const int __DealsCount = 10;
        private Deal[] _Deals;
        private async Task InitializeDeals()
        {
            var timer = Stopwatch.StartNew();
            _Logger.LogInformation("Инициализация книг...");

            var rnd = new Random();
            _Deals = Enumerable.Range(1, __DealsCount)
               .Select(i => new Deal
               {
                   Id = i,
                   Name = $"Сделка - {i}"                   
               })
               .ToArray();

            await _db.Deals.AddRangeAsync(_Deals);
            await _db.SaveChangesAsync();

            _Logger.LogInformation("Инициализация книг выполнена за {0} мс", timer.ElapsedMilliseconds);
        }
    }
}
