## Project using Microsoft.AspNetCore.OData 7.0.0-Nightly201801301327

Checked the some issues, which must resolve for simple work the project.

* Valid Put request:
  {"id":"1","name":"Colla","category":{"id":"2","name":"Cool", "created":"2017-03-07T01:33:52.433+07:00"}}

Invalid Put request:
  {"id":"1","name":"Colla","category":{"id":"2","name":"Cool", "created":"7/3/2017 01:33 AM -07:00"}}

* Getting input array objects:

  ``public IActionResult Post([FromBody] List<Product> dtos)
  {
    return Ok(dtos);
  }``
  
In finish, dtos is null, if using of register entity in EDM model:

`var builder = new ODataConventionModelBuilder(app.ApplicationServices);  
builder.EntitySet<Product>("Products");  
builder.ComplexType<ProductCategory>();  
builder.EnableLowerCamelCase();`
  
But if using another entity(ProductDTO):
  `public IActionResult Post([FromBody] List<ProductDTO> dtos)
  {
    return Ok(dtos);
  }`  
then dtos will have validate values(list objects)
