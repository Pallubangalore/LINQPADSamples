<Query Kind="Program" />

void Main()
{

var customers = new List < Customer > () {
  new Customer() {
    Id = Guid.NewGuid().ToString(),
     Name = "Customer1"
   },
   new Customer() {
    Id = Guid.NewGuid().ToString(),
     Name = "Customer2"
   }
 };

	var purchases = new List < Purchase > () {
 new Purchase() {
   Id = Guid.NewGuid().ToString(),
    CustomerId = customers[0].Id,
    Description = "Customer1-Purchase1"
  },
  new Purchase() {
   Id = Guid.NewGuid().ToString(),
    CustomerId = customers[0].Id,
    Description = "Customer1-Purchase2"
  },
  new Purchase() {
   Id = Guid.NewGuid().ToString(),
    CustomerId = customers[1].Id,
    Description = "Customer2-Purchase1"
  },
  new Purchase() {
   Id = Guid.NewGuid().ToString(),
   
 
   CustomerId = customers[1].Id,
    Description = "Customer2-Purchase2"
  }
};
var purchaseItems = new List < PurchaseItem > () {
 new PurchaseItem() {
   Id = Guid.NewGuid().ToString(),
    PurchaseId = purchases[0].Id,
    Detail = "Purchase1-PurchaseItem1"
  },
  new PurchaseItem() {
   Id = Guid.NewGuid().ToString(),
    PurchaseId = purchases[1].Id,
    Detail = "Purchase2-PurchaseItem1"
  },
  new PurchaseItem() {
   Id = Guid.NewGuid().ToString(),
    PurchaseId = purchases[1].Id,
    Detail = "Purchase2-PurchaseItem2"
  },
  new PurchaseItem() {
   Id = Guid.NewGuid().ToString(),
    PurchaseId = purchases[3].Id,
    Detail = "Purchase3-PurchaseItem1"
  }
};

var result = from c in customers
join p in purchases on c.Id equals p.CustomerId // first join
join pi in purchaseItems on p.Id equals pi.PurchaseId // second join
select new {
 c.Name, p.Description, pi.Detail
};

result.Dump();
}

public class Customer {
 public string Id {
  get;
  set;
 } // A unique Id that identifies customer
 public string Name {
  get;
  set;
 }
}
public class Purchase {
 public string Id {
  get;
  set;
 }
 public string CustomerId {
  get;
  set;
 }
 public string Description {
  get;
  set;
 }
}
public class PurchaseItem {
 public string Id {
  get;
  set;
 }
 public string PurchaseId {
  get;
  set;
 }
 public string Detail {
  get;
  set;
 }
}

 