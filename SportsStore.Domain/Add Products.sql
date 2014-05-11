select 'insert into Products(Name, Description, Category, Price) values(''' + name + ''', ''' + [description] + ''', ''' + [category] + ''', ' + cast(Price as varchar) + ')' as query from Products


insert into Products(Name, Description, Category, Price) values('Kayak', 'A boat for one person', 'Watersports', 275.00)
insert into Products(Name, Description, Category, Price) values('Lifejacket', 'Protective and fashionable', 'Watersports', 48.95)
insert into Products(Name, Description, Category, Price) values('Soccer Ball', 'FIFA-approved size and weight', 'Soccer', 19.50)
insert into Products(Name, Description, Category, Price) values('Corner Flags', 'Give your playing field a professional touch', 'Soccer', 34.95)
insert into Products(Name, Description, Category, Price) values('Stadium', 'Flat-packed 35,000-seat stadium', 'Soccer', 795000.00)
insert into Products(Name, Description, Category, Price) values('Thinking Cap', 'Improve your brain efficiency by 75%', 'Chess', 16.00)
insert into Products(Name, Description, Category, Price) values('Unsteady Chair', 'Secretly give your opponent a disadvantage', 'Chess', 29.95)
insert into Products(Name, Description, Category, Price) values('Human Chess Board', 'A fun game for the family', 'Chess', 75.00)
insert into Products(Name, Description, Category, Price) values('Bling-Bling King', 'Gold-plated, diamond-studded King', 'Chess', 12000.00)