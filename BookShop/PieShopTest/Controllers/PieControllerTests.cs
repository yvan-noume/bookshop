﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookShop.Controllers;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using PieShopTest.Mocks;

namespace PieShopTest.Controllers
{
    public class PieControllerTests
    {
        [Fact]
        public void List_EmptyCategory_ReturnsAllPies()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var mockPieRepository = RepositoryMocks.GetPieRepository();

            var pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

            //act
            var result = pieController.List("");

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(10, pieListViewModel.Pies.Count());
        }
    }
}
