# 9. Composition vs Aggregation. Unit testing

## Task 1
Create struct Point:
- fields x and y;
- method ToString(), which return the Point in format "(x,y)";
- method DistanceTo() with parameter Point, which returns the distance to the given point (e.g. point1.DistanceTo(point2));
- method DistanceToOrigin() computes the Euclidean distance from the point to the origin using the formula \(\sqrt{\left(x-0\right)^{2}+\left(y-0\right)^{2}}\) which simplifies to \(\sqrt{x^{2}+y^{2}}\)

Create class Triangle:
- fields **vertex1, vertex2, vertex3** of type **Point;**
- constructor;
- methods **Perimeter()** - calculate the perimeter of the shape, **Area()** - its area, **Print()** - to provide the output;
- method **ClosestVertexToOrigin()**  to find the vertex of a triangle that is closest to the origin point (0,0). The method calculates the distance of each vertex of the triangle (vertex1, vertex2, vertex3) to the origin. This is achieved by calling the **DistanceToOrigin()** method of the **Point** struct.

In the **Main()** create a list of 3 triangles and write into the console the information about these shapes.

Print the triangle with the vertex which is the closest to the origin (0,0)

For example:

- **Test:**

ShapeProblem.StudentMain();

//StudentMain is your Main function. The StudentMain name is used for testing

- **Result:**

Triangle vertices: (0,0), (1,0), (0,1)

Perimeter: 3.414213562373095

Area: 0.49999999999999983

Triangle vertices: (0,0), (2,0), (1,2)

Perimeter: 6.47213595499958

Area: 2

Triangle vertices: (1,1), (4,1), (1,3)

Perimeter: 8.60555127546399

Area: 3.0000000000000013

Triangle with a vertex closest to the origin:

Triangle vertices: (0,0), (1,0), (0,1)

Perimeter: 3.414213562373095

Area: 0.49999999999999983



### Tests
**Test 1**
- **Test:**

ShapeProblem.StudentMain();

//StudentMain is your Main function. The StudentMain name is used for testing

- **Expected:**

Triangle vertices: (0,0), (1,0), (0,1)

Perimeter: 3.414213562373095

Area: 0.49999999999999983

Triangle vertices: (0,0), (2,0), (1,2)

Perimeter: 6.47213595499958

Area: 2

Triangle vertices: (1,1), (4,1), (1,3)

Perimeter: 8.60555127546399

Area: 3.0000000000000013

Triangle with a vertex closest to the origin:

Triangle vertices: (0,0), (1,0), (0,1)

Perimeter: 3.414213562373095

Area: 0.49999999999999983

- **Got:**

Triangle vertices: (0,0), (1,0), (0,1)

Perimeter: 3.414213562373095

Area: 0.49999999999999983

Triangle vertices: (0,0), (2,0), (1,2)

Perimeter: 6.47213595499958

Area: 2

Triangle vertices: (1,1), (4,1), (1,3)

Perimeter: 8.60555127546399

Area: 3.0000000000000013

Triangle with a vertex closest to the origin:

Triangle vertices: (0,0), (1,0), (0,1)

Perimeter: 3.414213562373095

Area: 0.49999999999999983

---

**Test 2**
- **Test:** Console.WriteLine(TestPointTriangleM.TestIfPerimeterIsCorrect());
- **Expected:** Perimeter calculation is Correct
- **Got:** Perimeter calculation is Correct

---

**Test 3**
- **Test:** Console.WriteLine(TestPointTriangleM.TestIfAreaIsCorrect());
- **Expected:** Area calculation is Correct
- **Got:** Area calculation is Correct

---

**Test 4**
- **Test:** Console.WriteLine(TestPointTriangleM.TestIfDistanceToIsCorrect());
- **Expected:** Distance from point1 to point2 calculation is Correct
- **Got:** Distance from point1 to point2 calculation is Correct

---

**Test 5**
- **Test:** Console.WriteLine(TestPointTriangleM.TestIfDistanceToOriginIsCorrect());
- **Expected:** Distance to origin calculation is Correct
- **Got:** Distance to origin calculation is Correct

---

**Test 6**
- **Test:** Console.WriteLine(TestPointTriangleM.TestIfClosestVertexToOriginCorrect());
- **Expected:** The Closest Vertex to Origin calculation is Correct
- **Got:** The Closest Vertex to Origin calculation is Correct

---


