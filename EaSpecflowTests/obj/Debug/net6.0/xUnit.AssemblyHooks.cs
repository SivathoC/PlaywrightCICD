// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using global::System.Runtime.CompilerServices;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::EaSpecflowTests_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "3.9.22")]
public class EaSpecflowTests_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EaSpecflowTests_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(EaSpecflowTests_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}

[global::Xunit.CollectionDefinition("SpecFlowNonParallelizableFeatures", DisableParallelization = true)]
public class EaSpecflowTests_SpecFlowNonParallelizableFeaturesCollectionDefinition
{
}
#pragma warning restore
