namespace VueApp1.Server
{
    public class CompanyData
    {
        public DateTime TableDate { get; set; } // 出表日期
        public string? DataYearMonth { get; set; } // 資料年月
        public int CompanyCode { get; set; } // 公司代號
        public string? CompanyName { get; set; } // 公司名稱
        public string? Industry { get; set; } // 產業別
        public decimal MonthlyRevenue { get; set; } // 營業收入-當月營收
        public decimal PreviousMonthRevenue { get; set; } // 營業收入-上月營收
        public decimal LastYearMonthlyRevenue { get; set; } // 營業收入-去年當月營收
        public decimal MonthOnMonthGrowth { get; set; } // 營業收入-上月比較增減(%)
        public decimal YearOnYearGrowth { get; set; } // 營業收入-去年同月增減(%)
        public decimal CumulativeMonthlyRevenue { get; set; } // 累計營業收入-當月累計營收
        public decimal LastYearCumulativeRevenue { get; set; } // 累計營業收入-去年累計營收
        public decimal YearToDateGrowth { get; set; } // 累計營業收入-前期比較增減(%)
        public string? Remarks { get; set; } // 備註
    }
}
