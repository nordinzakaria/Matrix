// See https://aka.ms/new-console-template for more information


/*
using MathTool;
using Mat2 = MathTool.Matrix2D;

Image2D A = new Image2D(400, 4000);    // create a 400x400 image
Image2D B = new Image2D(400, 400);    // create a 400x400 image

A.Randomize();          // randomize image A
A.Display("Original A");

B.Randomize();          // randomize image B
float diff = A.Diff(B);     // find diff betw A and B
Console.WriteLine("diff is "+ diff);    

A.Brighten(10);  // Brighten image A
A.Display("Brighten version");         // save to MatD.txt

Array2D Aarr = new Image2D();  // test polymorphism
Aarr.Resize(A.NRow, A.NCol);  // resize to same size as A
Aarr.Copy(B);  // copy B into Aarr

Image2D C = (Image2D)Aarr;  // assign Aar to C
C.Display("C");         // display C
*/


using MathTool;
using Mat2 = MathTool.Matrix2D;  

Mat2 A = new Mat2(4, 4);    // create a 4x4 matrix
Mat2 B = new Mat2(4, 4);    // create a 4x4 matrix

A.Randomize();          // randomize the values of A
B.Randomize();          // randomize the values of B
Mat2 C = A.Add(B);     // add B and A to obtain C
C.Save("MatC.txt");    // save to MatC.txt
Mat2 D = new Mat2(C);  // D will be a copy of C
D.Save("MatD.txt");         // save to MatD.txt

Array2D Aarr = new Mat2();  // create a Mat2 object, assign to Aarr
Aarr.Resize(4, 4);  // resize to 4 4
Aarr.Copy(C);  // copy C into Aarr

D = C.Minus((Matrix2D)Aarr);  // C - Aarr = D
D.Save("DminusAarr.txt");





/*
using Mat = MathTool.Matrix;

Console.WriteLine("Hello, World!");
Mat A = new Mat(10, 10);
Mat B = new Mat(10, 10);
A.Randomize();
B.Randomize();

Mat C = A.Add(B);
*/


