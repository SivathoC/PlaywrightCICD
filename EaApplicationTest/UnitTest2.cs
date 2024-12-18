using AutoFixture.Xunit2;
using EaApplicationTest.Fixture;
using EaApplicationTest.Models;
using EaApplicationTest.Pages;
using EaFramework.Config;
using EaFramework.Driver;
using Microsoft.Playwright;

namespace EaApplicationTest;


public class UnitTest2
{
    private readonly ITestFixtureBase _testFixtureBase;
    private readonly IProductListPage _productListPage;
    private readonly IProductPage _productPage;

    public UnitTest2(ITestFixtureBase testFixtureBase, IProductListPage productListPage, IProductPage productPage)
    {
        _testFixtureBase = testFixtureBase;
        _productListPage = productListPage;
        _productPage = productPage;
    }

    [Theory, AutoData]
    public async Task TestWithAutoFixtureData(Product product)
    {
        await _testFixtureBase.NavigateToUrl();
    
        await _productListPage.CreateProductAsync();
        await _productPage.CreateProduct(product);
        await _productPage.ClickCreate();
        
        await _productListPage.ClickProductFromList(product.Name);
    
        
        var element = _productListPage.IsProductCreated(product.Name);
        await Assertions.Expect(element).ToBeVisibleAsync();
    }
}