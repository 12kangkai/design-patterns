# **📚 Design Patterns（设计模式合集）**

> 一套基于 **C# 实现的设计模式实战仓库**，包含完整讲解 + 示例代码 + README 文档，适用于学习、面试准备与实际项目参考。

------

## **🚀 项目简介**

本仓库系统整理了 **GoF 23 种设计模式**，每个模式都具备：

- ✅ 清晰的结构说明
- ✅ Mermaid 图（类图 / 时序图）
- ✅ C# 经典示例
- ✅ 实际业务案例
- ✅ 独立 README 文档

------

## **🧠 设计模式分类**

设计模式按照经典分类分为三大类：

------

### **🏗️ 一、创建型模式（Creational Patterns）**

> 关注 **对象的创建方式**

| **模式**                                                     | **说明**                   |
| ------------------------------------------------------------ | -------------------------- |
| [单例模式（Singleton）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Creational/SingletonDemo) | 保证一个类只有一个实例     |
| [工厂方法模式（Factory Method）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Creational/FactoryMethodDemo) | 将对象创建延迟到子类       |
| [抽象工厂模式（Abstract Factory）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Creational/AbstractFactoryDemo) | 创建一组相关对象（产品族） |
| [建造者模式（Builder）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Creational/BuilderDemo) | 分步骤构建复杂对象         |
| [原型模式（Prototype）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Creational/PrototypeDemo) | 通过复制创建对象           |

------

### **🧩 二、结构型模式（Structural Patterns）**

> 关注 **类和对象的组合结构**

| **模式**                                                     | **说明**       |
| ------------------------------------------------------------ | -------------- |
| [适配器模式（Adapter）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/AdapterDemo) | 接口转换       |
| [桥接模式（Bridge）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/BridgeDemo) | 抽象与实现分离 |
| [组合模式（Composite）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/CompositeDemo) | 树形结构       |
| [装饰模式（Decorator）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/DecoratorDemo) | 动态扩展功能   |
| [外观模式（Facade）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/FacadeDemo) | 简化复杂系统   |
| [享元模式（Flyweight）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/FlyweightDemo) | 共享对象       |
| [代理模式（Proxy）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Structural/ProxyDemo) | 控制访问       |

------

### **🔄 三、行为型模式（Behavioral Patterns）**

> 关注 **对象之间的交互**

| **模式**                                                     | **说明**       |
| ------------------------------------------------------------ | -------------- |
| [责任链模式（Chain of Responsibility）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/ChainOfResponsibilityDemo) | 请求传递       |
| [命令模式（Command）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/CommandDemo) | 请求封装为对象 |
| [解释器模式（Interpreter）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/InterpreterDemo) | 语法解析       |
| [迭代器模式（Iterator）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/IteratorDemo) | 遍历集合       |
| [中介者模式（Mediator）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/MediatorDemo) | 解耦对象交互   |
| [备忘录模式（Memento）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/MementoDemo) | 状态恢复       |
| [观察者模式（Observer）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/ObserverDemo) | 发布订阅       |
| [状态模式（State）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/StateDemo) | 状态驱动行为   |
| [策略模式（Strategy）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/StrategyDemo) | 算法替换       |
| [模板方法模式（Template Method）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/TemplateMethodDemo) | 固定流程       |
| [访问者模式（Visitor）](https://github.com/12kangkai/design-patterns/tree/main/DesignPatterns/Behavioral/VisitorDemo) | 操作与结构分离 |

------

## **📂 项目结构**

```bash
DesignPatterns/
│
├── Creational/
│   ├── Singleton/
│   ├── FactoryMethod/
│   ├── AbstractFactory/
│   └── ...
│
├── Structural/
│   ├── Adapter/
│   ├── Bridge/
│   └── ...
│
├── Behavioral/
│   ├── Observer/
│   ├── Strategy/
│   └── ...
│
└── README.md
```

------

## **📖 学习路线建议**

如果你是第一次系统学习设计模式，推荐按以下顺序：

### **✅ 入门阶段（最常用）**

- 单例
- 工厂方法
- 策略
- 观察者

### **✅ 进阶阶段（理解设计思想）**

- 抽象工厂
- 模板方法
- 状态
- 责任链

### **✅ 高阶阶段（架构能力）**

- 访问者
- 中介者
- 享元
- 组合

------

## **📌 总结**

> 设计模式不是代码技巧，而是**解决问题的经验总结**

本仓库帮助你做到：

- ✅ 看懂设计模式
- ✅ 写出设计模式
- ✅ 用在真实项目中

