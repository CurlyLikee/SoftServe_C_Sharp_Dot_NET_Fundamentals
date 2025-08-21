# 6. Inheritance in C#. Abstract class. Polymorphism

## Task 1
Create abstract class Shape with field name and property Name.

Add constructor with 1 parameter  and abstract methods Area() and Perimeter(), which can return area and perimeter of shape;

Create classes Circle and Square derived from Shape with field radius (for Circle) and side (for Square).   Add necessary constructors and properties to these classes, and override methods from the abstract class Shape. (Constructors of Circle and Square should take 2 arguments: string for name and double for radius or side correspondingly.)

Create class Operator with the public static method GetInfo that takes a list of Shape as a parameter, and writes the name, area, and perimeter of all shapes.

Add method GetLargestPerimeter to the class Operator that finds a shape with the largest perimeter and prints its name.

Add method  Sort  to the class Operator that sorts shapes by area and prints Name property of each item of the obtained list (Remember about IComparable)

### Tests
**Test 1**
- **Test:** Console.WriteLine(Reflector.IsTypeAbstractClass("MyProgram.Shape"));
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:** Console.WriteLine(Reflector.HasTypeField("MyProgram.Shape", "name", typeof(string)));
- **Expected:** True
- **Got:** True

---

**Test 3**
- **Test:** Console.WriteLine(Reflector.HasTypeProperty("MyProgram.Shape", "Name", typeof(string)));
- **Expected:** True
- **Got:** True

---

**Test 4**
- **Test:** Console.WriteLine(Reflector.HasTypeConstructor(Type.GetType("MyProgram.Shape"), new Type[] {typeof(string)}));
- **Expected:** True
- **Got:** True

---

**Test 5**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(Type.GetType("MyProgram.Shape"), "Area", new Type[] {}));
- **Expected:** True
- **Got:** True

---

**Test 6**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(Type.GetType("MyProgram.Shape"), "Perimeter", new Type[] {}));
- **Expected:** True
- **Got:** True

---

**Test 7**
- **Test:** Console.WriteLine(Reflector.IsDeclaredMethodAbstract(Type.GetType("MyProgram.Shape"), "Area", new Type[] {}));
- **Expected:** True
- **Got:** True

---

**Test 8**
- **Test:** Console.WriteLine(Reflector.IsDeclaredMethodAbstract(Type.GetType("MyProgram.Shape"), "Perimeter", new Type[] {}));
- **Expected:** True
- **Got:** True

---

**Test 9**
- **Test:** Console.WriteLine(Reflector.IsTypeAbstractClass("MyProgram.Circle"));
- **Expected:** False
- **Got:** False

---

**Test 10**
- **Test:** Console.WriteLine(Reflector.IsTypeAbstractClass("MyProgram.Square"));
- **Expected:** False
- **Got:** False

---

**Test 11**
- **Test:** Console.WriteLine(Type.GetType("MyProgram.Circle", false).IsSubclassOf(Type.GetType("MyProgram.Shape", false)));
- **Expected:** True
- **Got:** True

---

**Test 12**
- **Test:** Console.WriteLine(Type.GetType("MyProgram.Square", false).IsSubclassOf(Type.GetType("MyProgram.Shape", false)));
- **Expected:** True
- **Got:** True

---

**Test 13**
- **Test:** Console.WriteLine(Reflector.HasTypeConstructor(Type.GetType("MyProgram.Circle"), new Type[] {typeof(string), typeof(double)}));
- **Expected:** True
- **Got:** True

---

**Test 14**
- **Test:** Console.WriteLine(Reflector.HasTypeConstructor(Type.GetType("MyProgram.Circle"), new Type[] {typeof(string), typeof(double)}));
- **Expected:** True
- **Got:** True

---

**Test 15**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(Type.GetType("MyProgram.Shape"), "CompareTo", new Type[] {Type.GetType("MyProgram.Shape")}));
- **Expected:** True
- **Got:** True

---

**Test 16**
- **Test:**
List<Shape> shapes = new List<Shape>{new Circle("circle1", 2),
new Circle("circle1", 3),
new Square("square1 ", 2),
new Square("square2 ", 8)};
Operator.Sort(shapes);
- **Expected:**
square1
circle1
circle1
square2
- **Got:**
square1
circle1
circle1
square2
---