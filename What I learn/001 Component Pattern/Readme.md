


![Honeycam 2021-09-11 21-28-39](https://user-images.githubusercontent.com/37606666/132947933-03ffb3a8-268d-426e-9261-7f6af55a1cf7.gif)

![001 Component pattern ](https://user-images.githubusercontent.com/37606666/132948168-58606489-a5a2-425f-9395-488e2877fecb.png)


Component Pattern 은 말 그대로 컴포넌트를 만들어 한 개체가 여러 분야를 서로 커플링 없이 다룰 수 있게 해준다.

로직을 기능별로 컴포넌트 화 하는 것, 클래스로 분리하고 Readability를 올리고
Decoupling 시키는 것은 협업하여 개발을 많이 해본 사람들에게는 자연히 녹아있는 습관이다.
이런 구조적인 개선 작업을 컴퍼넌트 패턴이라고 명명해두었다.

Unity 의 게임 오브젝트는 컴퍼넌트 패턴이 잘 반영되어 설계된 클래스라고 할 수 있다.
GetComponent Method로 각각의 Decoupling 된 하위 컴퍼넌트들을 불러서 사용할수 있게 해 두었다
(GameManager에 Function 을 넣어두고 Onclick 시 call 하는 등)

유니티는 새로운 행동을 추가하는 컴포지션(Composition) 구조를 채용한다.
이 점은 상속(Inheritance) 를 통해 확장되는 오브젝트 지향 클래스 계층과는 위상을 달리한다.

--

Code review point

1. Script : Move_Forward 

-이동 메서드의 매개변수로 방향,속도 를 추가하여 코드의 중복을 제거해본다.
-이동 방식을 Trasform 의 Translate 가 아니라 힘을 가하거나 ( Add force ) 속도를 추가하는 방식 ( Velocity )
를 고려해본다.

2. Script : Move_Rotate

-이동 속도, 방향의 매개변수를 private으로 설정하고 get,set 등의 메서드로 접근하여 캡슐화를 시도해본다.
(이유: 이동속도는 게임에서 중요한 역할을 하므로 오류 방지)

-다양하게 회전을 할 수 있도록 Rotate 코루틴을 보완한다. 
(x 축과 y축, z 축 모두 회전할 수 있어야하고 조합할 수 있어야하고, 또 쉽게 수정이 가능하도록 해본다)
