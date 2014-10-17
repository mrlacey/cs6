using System;;
using System.Threading.Tasks;

namespace CSharpSixSamples
{
    public class ExceptionHandlingImprovements
    {
        public async void AwaitInCatchAndFinallyBlocks()
        {
            try
            {
                await DoSomethingThatMayThrowAnException();
            }
            catch (Exception exc)
            {
                await LogExceptionAsync(exc);
            }
            finally
            {
                await DoSomethingFinal();
            }
        }

        private Task DoSomethingThatMayThrowAnException()
        {
            throw new NotImplementedException();
        }

        private Task DoSomethingFinal()
        {
            throw new NotImplementedException();
        }

        private Task LogExceptionAsync(Exception exc)
        {
            throw new NotImplementedException();
        }

        public void SomethingThatHandlesDifferentErrorsInDifferentWays()
        {
            // As with error handling previously - the order matters
            // The first to match will be used.
            try
            {
                DoSomethingThatMayThrowAnException();
            }
            catch (CustomException cex) if (cex.Seriousness == CustomException.Severity.Critical)
            {
                Console.WriteLine("A critical error occurred");
            }
            catch (CustomException cex) if (cex.Seriousness == CustomException.Severity.High)
            {
                Console.WriteLine("A high severity error occurred");
            }
            catch (CustomException cex)
            {
                Console.WriteLine("A custom exception");
            }
            catch (Exception ecx)
            {
                Console.WriteLine("Some error occurred");
            }
        }

        public class CustomException : Exception
        {
            public Severity Seriousness { get; set; }

            public enum Severity
            {
                Low,
                Medium,
                High,
                Critical
            }
        }
    }

}
