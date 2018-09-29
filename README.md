# Binodata.Autompper.Extension
This is a project extension for automapper

##Dependency
* [AutoMapper 7.0.1](https://www.nuget.org/packages/automapper/)



##How To Use 

###Example

```C#

private MapperConfiguration config;

private void InitMapperConfig()
{
    config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<SourceModel, DestModel>();
    });
}


public void ConvertUse(){

	InitMapperConfig();

	SourceModel source = new SourceModel();
	source.Name = "Binodata";
	source.Price = 10000000000;

	var destModel = config.ConvertModel(source, new DestModel());

}

```