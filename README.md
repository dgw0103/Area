# Area
Call event when game character enter any area by using trigger. Like this.
<img src="https://github.com/user-attachments/assets/79d48e72-d3fd-4140-9e07-a751a9bd3295"><br><br>

## Structure
<img src="https://github.com/user-attachments/assets/59cc5081-d946-46b4-b8c3-24775b170058">
This picture means you should just do two things.
1. Write your 'AreaEventData' script and create asset.
2. Write script to reference from 'AreaEventData'. (Actually, this is not essential if you want.)

## How to use?
1. Create a script through right-click > Create > Scripting > MonoBehaviour script or right-click > Create > C# script in project window, and name you want.
2. Change parent class to 'AreaEventData'.
3. Implement functions.
4. Write 'Debug.Log("Enter");' in OnEnter function.
5. Write 'Debug.Log("Exit");' in OnExit function.
6. Refresh at editor. Then, the class has a 'CreateAssetMenu' attribute automatically.
7. Create event asset through right-click > Create > AreaEventData > [class name] in project window.
8. Create Cube and Capsule through right-click > 3D Object > Cube, Capsule in hierarchy window.
9. Add 'Area' component to cube and set true 'Is Trigger'.
10. Add 'Character', Rigidbody component to capsule and set true 'Is Kinematic'.
11. Run play mode and move the capsule object into the cube in scene window.
12. See console window and check 'Enter' text.
13. If the capsule go out cube, it will write 'Exit' in console window.
