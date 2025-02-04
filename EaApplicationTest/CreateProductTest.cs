using AutoFixture.Xunit2;
using EaApplicationTest.Fixture;
using EaApplicationTest.Models;
using EaApplicationTest.Pages;
using EaFramework.Config;
using EaFramework.Driver;
using Microsoft.Playwright;

namespace EaApplicationTest;

public class CreateProductTest
{
    private readonly ITestFixtureBase _testFixtureBase;
    private readonly IProductListPage _productListPage;
    private readonly IProductPage _productPage;

    public CreateProductTest(ITestFixtureBase testFixtureBase, IProductListPage productListPage, IProductPage productPage)
    {
        _testFixtureBase = testFixtureBase;
        _productListPage = productListPage;
        _productPage = productPage;
    }

     [Theory (Skip = "Skipping local tests" ), AutoData]
     public async Task TestWithAutoFixtureData(Product product)
     {
         // Arrange
         await _testFixtureBase.NavigateToUrl();
         await _productListPage.CreateProductAsync();
         await _productPage.CreateProduct(product);
         await _productPage.ClickCreate();
         
         // Act
         await _productListPage.ClickProductFromList(product.Name);
    
         // Assert
         var element = _productListPage.IsProductCreated(product.Name);
         await Assertions.Expect(element).ToBeVisibleAsync();
    }
}