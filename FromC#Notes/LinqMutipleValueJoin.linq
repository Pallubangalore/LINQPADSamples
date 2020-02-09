<Query Kind="Statements" />

PropertyInfo[] stringProps = typeof (string).GetProperties();//string properties
PropertyInfo[] builderProps = typeof(StringBuilder).GetProperties();//stringbuilder properties

var query = from s in stringProps
						join b in builderProps on
						new {s.Name,s.PropertyType} equals new {b.Name, b.PropertyType}
						select new 
						{
						s.Name, s.PropertyType,
						StringToken = s.MetadataToken,
						StringBuilderToken = b.MetadataToken
						};
						
query.Dump();