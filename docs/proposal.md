# <p align="center">�����ȹ��</p>
![python](https://img.shields.io/badge/Python-numpy-blue?logo=Python)
![Unity](https://img.shields.io/badge/Oculus-Unity-yellow?logo=Unity)
![React](https://img.shields.io/badge/React-Frontend-fb5d65?logo=React)
![Node.js](https://img.shields.io/badge/Node.js-Javascript-48d1cc?logo=Node.js)
![MongoDB](https://img.shields.io/badge/MongoDB-NoSQL-b6e0c6?logo=MongoDB)
![Ubuntu](https://img.shields.io/badge/Ubuntu-Server-red?logo=Ubuntu)

### <p align="center">VR Rhythm Game Beat Maker Using Deep Learning</p><p align="center"><span style="color:#0064FF">VRR</span></p>    

#### <p align="center">Ver. 1.0</p>
#### <p align="center">2019.10.01</p>    
#### <p align="center">�ѱ��ܱ�����б�</p>
#### <p align="center">������Ű��а�</p>
#### <p align="center">VRR Team</p>

**<p align="center">�ڿ��� ����� �輼�� ��ȣ�� ����ö</p>**     

***
#### <p align="center"><u>�Ӹ���</u></p>
<p align="center">�� ������ VRR �÷����� ���� �����ȹ���� ���� ������ �����մϴ�.</p>

#### ?? Index

> ###### 1. ����
>> ######   1-1 [���� ����](#����-����)
>> ######   1-2 [���� ��ȹ ���](#����-��ȹ-���)
>> ######   1-3 [���� �Ұ�](#����-�Ұ�)
> ###### 2. ���
>>  ######  2-1 [��� �Ұ�](#���-�Ұ�)
> ###### 3. ����
>>  ######  3-1 [���� ����](#����-����)
>>  ######  3-2 [��� ����](#���-����)
>>  ######  3-3 [����](#����)
> ###### 4. ��ȹ
>>  ######  4-1 [���� ���� ��ȹ](#����-����-��ȹ)
>>  ######  4-2 [�����д�](#�����д�)
>>  ######  4-3 [���� �� ���� ��ȹ](#����-��-����-��ȹ)

***

![img](/img/img1.PNG)

</br>

#### ���� ����

 - **VRR�̶�?**

 ![img](/img/vrr.PNG)
</br>
    VR�� Kinect ����ν��� ���� ��Ʈ���Ӱ� Auto Beat Note Mapping ����, ���� �÷����� ������ �����Ѵ�
</br>
</br>

#### ���� ��ȹ ���
 - **���� ������ 2�ο����� �����ϸ� ��� �� �� ������?**
</br>
    ��������� 1�ο����� ����ǰų� 2�ο������� ������ �����ϴ� �����Դϴ�. ���� VRR���� �� ����ִ� ���� ������ ������ӿ� �����ϸ� ������� �� ���ҽ��ϴ�.    
</br>
</br>

 - **���� ������ ��Ʈ ���� ��ȿ�� ������ ���?**
</br>
    ��â����� ������� ������ �α⸦ ���� �ִ� ��������� Play�ϱ� ���ؼ� Note�� �� �ʿ��մϴ�. ������ �̸� ������ �� Note������ ����� ���� �������� ����ٴ� ��ȿ���� ������ ����� ������ ����߽��ϴ�.
</br>
</br>

***

#### ���� �Ұ�
 -  **:mag: �� �÷���**

 ![img](/img/platform.PNG)
 </br>
    ������ kit�� ���� ���� ������ license ��ȣ�� �ް� �Ǹ� �� �÷����� Login�Ͽ� VRR Play ��ϰ� ���� �����Ͽ� ����� �ڽŸ��� Beat Note�� Ȯ���� �� �ִ�    
</br>

 -   **:video_game: VR �������**

 ![img](/img/unity.PNG)
 </br>
 VR ��⸦ �����ϰ� Kinect�� �νĵ� Player�� Unity UI�� ���� �α����ϰ� Play�ϰ� ���� ���� ���� �� VR ��������� ����    
</br>

  -   **:musical_score: Auto Beat Node Mapping**

  ![img](/img/deeplearning.PNG)
  </br>
  �ڽ��� Play �ϰ� ���� ���� ������ Auto Beat Note Making ����� �̿��� ������ ����־� �ڵ����� ������ Note�� �� �÷����� �����ϰ� ���� Play�ϰų� �ٸ� Player�� ������ �� �ִ�.
</br>

  -  **������**

![img](/img/architecture.PNG)
</br>
</br>

***

#### ��� �Ұ�
##### VR
<img width="150" height="150">![img](/img/technology01.PNG)</img>
* Virtual Reality�� ���ڷ� '��������'�̶�� ��
* ����� ���� ������ ���迡�� ����� ������ ���� ü���� �� �� �ֵ��� �ϴ� ���
* ���� ���԰����� ���Ӱ� ���� �������θ�Ʈ �о߰� ���� ������ �ִ�.
>VR�� ������� �þ߿� �� �� display�� ������ ���� ���� ���尨�� ���԰��� �� �� �ִ�

</br>
##### Kinect
<img width="150" height="150">![img](/img/technology02.PNG)</img>
* RGB������ IR������ �̿��� 3���� 
* �ν� ��ü�� �ֿ� ��� ��ġ ������ ����
* ���� ����ũ�� ���� �ν�
> Kinect�� ��ü�� 25���� �ֿ� ��� ��ġ�� �ν��Ͽ�, �νĵ� ��� ��ġ �����͸� ���� ���ֱ� ������ ����� ��ü���� �ൿ �� �������� �� �� �ִ�.     
_**Gesture recognition**_ : ��� ���� �������� �ν��� ���� ��ȣ�ۿ�

</br>
##### VRR : Kinect & VR ��� ����
![img](/img/unity+kinect.gif)
<img width="350" height="150">![img](/img/technology03.PNG)</img>
> ��������� ���� ����ְ� Play �ϱ����� �ֱ������� ���� ������ Kinect�� ���� Gesture recognition ������� ���� ���ϴ� ������ ��Ҹ� �߰��Ͽ���.

</br>
##### Deep learning
![img](/img/technology04.PNG)
</br>
* �����н��� ������ �־��� ���¿��� �н��ϴ� �˰����� �ǹ�
* �Է� ���� ������ ������ Training Data�� �̿��Ͽ� �н�
* �� �н��� ����� �������� ������ �����Ϳ� ���� �̷� ���� �����ϴ� ���
> VRR�� Note�� �����ϴ� ������ �ʿ��� Data�� ��ó���� �� Model�� �н��Ͽ� ���ο� Beat Note�� �ڵ����� ������ �� �ִ�.

***

#### ���� ����
</br>
![img](/img/marketTrends2.PNG)
```bash
| [���嵿�� �ڷ� 1] TrendForce  
```
```bash
| [���嵿�� �ڷ� 2] Digi-capital, NH�������� WM����ġ��
```
###### VR��Ⱑ ���޵Ǹ鼭 ������ ���嵵 ���� ������ �����̸�, 2020��?VR?������ ������ ���� �̻���?VR?������ ������ ������ �����ϰ� �־�?���� ���� ���Ӿ�ü����?VR?������ ���� �߿� ������, VR?������ �����ϴ� ��ü�鵵 ���������� ������ ������ ����
</br>

![img](/img/marketTrends3.PNG)
```bash
| [���嵿�� �ڷ� 3] �λ����ͽ� (VR ��� ���� ���)  
```
###### VR ����� ���԰��� ������ �� �ִ� ��� �о߿� ���� �����ϸ�, ���� ���ӽ��忡�� ���� Ȱ���� Ȯ��ǰ� �ִ�. ũ�� ����, ����, �Ƿ�, ����, ���/����, ����/��� �о߿� ����Ǹ� ���� �оߴ� �Ʒ��� ����.
</br>

![img](/img/marketTrends4.PNG)
```bash
| [���嵿�� �ڷ� 4] NH�������� WM����ġ��
```
![img](/img/marketTrends5.PNG)
```bash
| [���嵿�� �ڷ� 5] �λ����ͽ�, VRR ���� (VR ���� ��� ��Ȳ)
```
###### �����鵵 ��� ǥ�� ���� ���� ������� ���� ������ �߻����� ���� �ʱ� ��ŸƮ������ ������� Ȱ���� �μ��պ�(M&A)�� �����Ͽ� VR ������� �پ��� ������, �� ������ ��� ���߰� ����ǰ ��ÿ� ������ ���ϰ� �ִ�.
</br>

***

#### ��� ����
</br>

![img](/img/businessModel.PNG)
</br>

#### ����
</br>

***

![img](/img/profit.PNG)
</br>

#### ���� ���� ��ȹ
</br>

![img](/img/plan.PNG)
![img](/img/plan2.PNG)

</br>

#### �����д�
</br>

![img](/img/role.PNG)
</br>

#### ���� �� ���� ��ȹ
</br>

![img](/img/devplan.PNG)