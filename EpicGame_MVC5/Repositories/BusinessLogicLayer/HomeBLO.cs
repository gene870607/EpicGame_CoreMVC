using EpicGame_MVC5.Repositories.DataOperationLayer;
using EpicGame_MVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpicGame_MVC5.Repositories.BusinessLogicLayer
{
    public class HomeBLO
    {
        private HomeDAO HomeDAO;
        public HomeBLO()
        {
            HomeDAO = new HomeDAO();
        }


        public HomeViewModels GetHomeViewModel()
        {
            HomeViewModels homeViewModels = new HomeViewModels();

            homeViewModels.TopSales = HomeDAO.GetTopSales();
            homeViewModels.BestDiscount = HomeDAO.GetProducts().OrderBy(x => x.Discount).Take(5).ToList();
            homeViewModels.Activities = HomeDAO.GetActivity();
            homeViewModels.MostRelated = HomeDAO.GetTopMostRelated();
            homeViewModels.BestRank = HomeDAO.GetTopBestRank();
            homeViewModels.BestPrice = HomeDAO.GetTopBestPrice();
            homeViewModels.MostFollowe = HomeDAO.GetTopMostFollowe();
            homeViewModels.FreeGame = HomeDAO.GetFreeGame();
            homeViewModels.TopDiscount = HomeDAO.GetTopDiscount();
            return homeViewModels;
        }
    }
}