public update(Person model)
{
    // Here model is model return from form on post
    var oldobj = db.Person.where(x=>x.ID = model.ID).SingleOrDefault();

    // Newly Inserted Code
    var UpdatedObj = (Person) Entity.CheckUpdateObject(oldobj, model);

    db.Entry(oldobj).CurrentValues.SetValues(UpdatedObj);
}

public static object CheckUpdateObject(object originalObj, object updateObj)
{
   foreach (var property in updateObj.GetType().GetProperties())
   {
      if (property.GetValue(updateObj, null) == null)
      {
         property.SetValue(updateObj,originalObj.GetType().GetProperty(property.Name)
         .GetValue(originalObj, null));
      }
   }
   return updateObj;
}
