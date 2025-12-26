using Xunit;

namespace Berger.Extensions.UserAgent.Tests
{
    public class ParserTests
    {
        [Fact]
        public void can_get_default_parser()
        {
            Parser parser = Parser.GetDefault();
            Assert.NotNull(parser);
        }

        [Fact]
        public void can_get_parser_from_input()
        {
            string yamlContent = this.GetTestResources("Berger.Extensions.UserAgent.Tests.Regexes.regexes.yaml");
            Parser parser = Parser.FromYaml(yamlContent);
            Assert.NotNull(parser);
        }
    }
}
