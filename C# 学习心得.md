

# C# 学习

## c#基本语法

注意：

- c#是大小写敏感的
- 所有的语句表达式必须以分号结尾
- 与Java不同的是，文件名和类名可以不同
- c#是一种面向对象的编程语言。在面向对象的程序设计方法中程序由各种对象组成，相同种类的对象通常具有相同的类型。

案例：

​		c罗和梅西同属与人类，所以两人类型相同

## **关键字**

- 关键字，是对编译器有**特殊意义**的**预定保留标识符**，它们**不能**在程序中用作标示符
- using 关键字

在任何c#程序中的第一条语句都是：

```c#
	using System;
```

using关键字用于在程序中包括命名空间。一个程序可以包括多个using语句。

## 表达式

- 表达式由操作数（operand)和运算符（operator）构成。运算符的示例包括+，-,*,/和new。操作数的示例包括文本，字段，局部变量和表达式。

- 当表达式包括多个运算符时，运算符的优先级（precedence）控制各运算符的计算顺序。例如，表达式x+y*z按x+（y *z)计算，因为 * 运算符的优先级高于+运算符。


| 类别 |     表达式      |           说明           |
| :--: | :-------------: | :----------------------: |
| 基本 |       x.m       |         成员访问         |
|      |     x(...)      |      方法和委托调用      |
|      |     x[...]      |     数组和索引器访问     |
|      |   new T(...)    |      对象和委托创建      |
|      | new T(...){...} | 使用初始值设定项创建对象 |
|      |    new{...}     |   匿名对象初始值设定项   |
|      |   new T[...]    |         数组创建         |

| 类别 | 表达式 |        说明        |
| :--: | :----: | :----------------: |
| 一元 |   +x   |        恒等        |
|      |   -x   |      求相反数      |
|      |   !x   |      逻辑求反      |
|      |   ~x   |      按位求反      |
|      |  ++x   |       前增量       |
|      |  --x   |       前减量       |
|      |  x++   |       后增量       |
|      |  x--   |       后减量       |
|      |  (t)x  | 将x显示转换为类型t |

| 类别 | 表达式  |                      说明                       |
| :--: | :-----: | :---------------------------------------------: |
| 二元 |  x * y  |                      乘法                       |
|      |  x / y  |                      除法                       |
|      |  x % y  |                      求余                       |
|      |  x + y  |                加法，字符串相加                 |
|      |  x -y   |                减法，字符串相减                 |
|      |  x<<y   |                     位左移                      |
|      |  x>>y   |                     位右移                      |
|      |  x<=y   |                   小于或等于                    |
|      |  x>=y   |                   大于或等于                    |
|      | x is t  |       如果x为t，则返回true，否则返回false       |
|      | x as t  |    返回转换为类型t的x，如果x不是t则返回null     |
|      |  x==y   |                      等于                       |
|      |  x!=y   |                     不等于                      |
|      |   x&y   |             整形按位AND,布尔逻辑AND             |
|      |  x??y   |   如果x为null，则计算结果为y，否则计算结果为x   |
| 三元 | x？y：z | 如果x为true，则对y求值；如果x为false，则对z求值 |



## 变量

- 变量是一个供程序储存数据盒子。在c#中，每个变量都有一个特定的类型，不同类型的变量其内存大小也不尽相同。

  c#提供的基本类型大致可以分为以下几类;

|    类型    |          举例          |
| :--------: | :--------------------: |
|  整数类型  | byte，shrot，int，long |
|   浮点型   |     float和double      |
| 十进制类型 |        decimal         |
|  布尔类型  |          bool          |
|  字符类型  |      string，char      |
|   空类型   |          null          |

## 注释

- c的注释方式

```c#
/*这个程序演示
c#语言多行注释
语法*/
```

- 单行注释是用’//'符号表示。例如;

```c#
//这是c#语言单行注释语法
```

- 文档注释用‘///’符号表示。例如;

```c#
/// <summary>
/// 应用程序的主入口点。
/// </summary>
/// <param name="arg">需要传入的参数</param>
pubilc static void Main(string[] args)
{

}
```

# c#语法进阶

## 分支语句

- **if语句**

```javascript
if(i>1){

}
```

- **if-else语句**

  ```javascript
  //如果
  if（i>1){
  	...
  else
  	...
  }
      
  if(i>=10){
      ...
   else if(i>0&&i<10){
      ...
   }
       else{
     - ...
   }
       
  ```



- **switch语句**

```javascript
switch(i){
	case 1:
		...
		break;
	case 2:
		...
		break;
	case 3:
		...
		break;
	default:
		...
		break;
}
```

## 循环语句

- for循环

```javascript

for(int i =0; i<0; i++)
	...
	}
```

- while循环

```javascript
int i =0
while(i<0){
	...
}
```

- do while循环

```javascript
do{
	...
}
while(i<10)
```

# 数组

- 数组是一组相同类型的数据
- 数组中的数据需要通过数字索引来访问

## 数组的声明

- 数组的声明需要使用**new** 关键字
- 在声明数组时，可以使用[]来**初始化**数组的元素
- 如果在数组声明之初没用使用大括号来初始化数组的元素，则需要指定数组的大小
- 在声明初始化有元素的数组时，也可以指定数组大小

```javascript
//声明没有元素的数组                                                                                                                                                                         w'w'we
int[] ints= new int[6]
//声明初始化有元素的数组
int[] ints= new int[]{1,3,4,5}
//在声明初始化有元素的数组时，也可以指定数组大小
string[] strings =new int[5]{"H","E","L","M","Q"}

```

## 通过索引获取数组中的元素

- 给数组指定长度时，数组准备存放多少元素，长度就设置为多少

- 用索引获取数组内的元素时，索引从0开始获取。

- 所以数组中最大的索引数字，比指定数组长度小1

  ```javascript
  //声明初始化有元素的数组
  int[] ints = new int[]{1,3,4,5}
  //获取数组中第1个的元素
  int i1= ints[0]
  //给数组内的元素赋值
  ints[0] = 1
  ```




# 案例一：西瓜购买案例

- 正逢双十一超市做活动当商品价格达到十元时就能打7.5折，现在需要到超市购买6斤的西瓜，超市的西瓜价格为1.9元每斤，请问现在购买西瓜花费了多少钱？

## 思考

- 以上需要设置几个变量？

需要设置四个变量分别为西瓜价格，折扣价格，购买数量（斤），花费总价

- 需要声明何种类型的变量？

```javascript
 double price = 1.9; //每斤购买单价
  int count = 6;//购买数量买6斤
 double discount = 0.75 //折扣价格为7.5折
  double totalPrice;//计算折前总价
```

- 现在需要购买16斤的西瓜，如果其中要求满几个10元，就在几个10元上打7.5折应该如何计算？

```c#
 double price = 1.9;
            int count = 16;
            double discount = 0.75;
            double totalPrice;
            totalPrice = price * count;
            int d= (int)(totalPrice/10);
            double totalten = 0;
           for (int i = 0; i < d; i++)
            {
                totalten = totalten+10 * discount;
            }
            double y = totalPrice % 10;
            totalPrice = totalPrice + y;
            MessageBox.Show(totalPrice.ToString());
```



## 总结

- **变量名**只用在**某一区域内**第一次出现才要**声明变量**
- **变量名**在区域内第二次出现时不用声明变量，而是直接使用之前声明的变量
- **变量名**命名是我们一般遵循**驼峰命名法**，即以**小写字母开头**，多个单词拼接时，除第一个单词，**其余字母大写**
- 在程序开发中可以修改之前保存的变量值

## 拓展

- (int)表示使用显示强制转换，时一种类型转换，c#默认整理时int32，因此使用此方法转成int32位，不遵循四舍五入，只截取整理部分；
- (int)5.21//输出5
- int.Parse()：只支持将string类型转成int，Parse就是把string类型转换成int，char，double...等，也就是*.parse(string)括号中一定是string类型。

```javascript
string st="5.21";
double n =5.21;
int.Parse(st);  //输出5
int.Parse(n);  //报错
```

- .Convert.Toint32(double value),不完全遵循四舍五入，如果value为两个整数中的数，则返回两者中的偶数。

```javascript
Console.Writeline(Convert.ToInt32(4.3));	//四舍五入，输出4
Console.Writeline(Convert.ToInt32(4.5));	//第一位小数为5，4.5在4和5之中，输出偶数4
Console.Writeline(Convert.ToInt32(4.53));	//四舍五入，输出5



Console.Writeline(Convert.ToInt32(5.3));	//四舍五入，输出5
Console.Writeline(Convert.ToInt32(5.5));	//第一位小数为5，5.5在5和6之中，输出偶数6
Console.Writeline(Convert.ToInt32(5.53));	//四舍五入，输出6


```

## 注意

- Convert.ToInt()和int.Parse()对于空值(null)的处理方式不同，Convert.ToInt()会返回0而不会产生任何异常，但int.Parse()则会产生异常

# 案例二：班级找同学案例

- 班级中有张三，李四，王五，赵六，田七，周八六位同学
- 请找出赵六同学送他回家
- 分别时用for循环和while循环实现

## while循环

```c#
 			//初始化数组
            string[] classStudents = { "张三", "李四", "王五", "赵六", "田七", "周八" };
            //创建变量i作为索引，以获取数组的值
            int i = 0;
            //存放数组遍历到的学生名
            string student = "";
            //作为标记使用，便于程序判断是否找到了指定学生
            bool isFind = true;
            while (student != "赵六")
            {
                //如果索引值已经大于等于数组的长度，则说明没有找到指定的学生
                if (i >= classStudents.Length) {
                    MessageBox.Show("没有找到要找的人");
                    //此时isFind标记为false，告诉系统，没有找到指定人
                    isFind = false;
                   //跳出循环
                    break;
                } 
                //将遍历的数组元素赋值给变量student
                student = classStudents[i++];   
            }
            //如果isFind为真，则说明找到指定目标，系统弹出指示
           if(isFind) MessageBox.Show("找到了"+student+"送他回家");
```

## for循环

```c#
 			//初始化数组
            string[] calssStudents = new string[] { "张三", "李四", "王五", "赵六", "田七", "周八" };
            //获取数组长度 
            int studentCount =  calssStudents.Length;
            //通过for循环遍历数组
            for (int i = 0; i < studentCount; i++)
            {
                //如果遍历的元素时找到赵六，则进入判断体
                if (calssStudents[i]=="赵六")
                {
                    MessageBox.Show("找到了" + calssStudents[i]+",送他回家");
                    break;//跳出循环
                }
```



## 总结

- 对于数组的初始化还有一种简单便捷的方式

```c#
string[] strs={"H","J","K","L"}
```

- 获取数组长度的方式：

  ```c#
  strings.Length
  ```

- 需要跳出某个循环时可以使用**break**关键字，跳出当前循环
- 满足某些条件后需要直接快进到下一轮循环而不再执行当前循环下的代码，可以使用**continue**关键字实现

