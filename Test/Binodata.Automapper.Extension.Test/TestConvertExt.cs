using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binodata.Automapper.Extension.Test
{
    [TestClass]
    public class TestConvertExt
    {
        private MapperConfiguration config;

        private void InitMapperConfig()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SourceModel, DestModel>();
            });
        }


        [TestMethod]
        public void Test_Automapper_Extension()
        {

            InitMapperConfig();

            SourceModel source = new SourceModel();
            source.Name = "Binodata";
            source.Price = 10000000000;

            var destModel = config.ConvertModel(source, new DestModel());


            string expectedName = "Binodata";
            long expectedPrice = 10000000000;

            Assert.AreEqual(expectedName, destModel.Name);
            Assert.AreEqual(expectedPrice, destModel.Price);
        }
    }


    internal class SourceModel{

        public string Name
        {
            get;
            set;
        }

        public long Price 
        {
            get;
            set;
        }


    }

    internal class DestModel{

        public string Name
        {
            get;
            set;
        }

        public long Price
        {
            get;
            set;
        }

    }
}
