using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace APITests
{
    public abstract class TestFixtureBase
    {
        /// <summary>
        /// Add here clean up tasks that you want to run After the testfixture has been run.
        /// </summary>
        protected List<Task> CleanupTasks { get; } = new List<Task>();

        /// <summary>
        /// Because the OneTimeTearDown will be inherited by the derived class, it will
        /// run after each fixture that derives this base class.
        /// See https://github.com/nunit/docs/wiki/OneTimeTearDown-Attribute for more
        /// </summary>
        [OneTimeTearDown]
        public async Task OneTimeTearDownTasks()
        {
            CleanupTasks.ForEach(t => t.Start());
            await Task.WhenAll(CleanupTasks);
        }
    }
}