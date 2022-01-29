using UnityEngine;

namespace Lightbug.GrabIt
{

[System.Serializable]
public class GrabObjectProperties{
	
	public bool m_useGravity = false;
	public float m_drag = 10;
	public float m_angularDrag = 10;
	public RigidbodyConstraints m_constraints = RigidbodyConstraints.FreezeRotation;


}

public class GrabIt : MonoBehaviour {


	[Header("Grab properties")]

	[SerializeField]
	[Range(4,50)]
	float m_grabSpeed = 7;

	[SerializeField]
	[Range(0.1f ,5)]
	float m_grabMinDistance = 1;

	[SerializeField]
	[Range(1 ,4)]
	float m_grabMaxDistance = 10;

	//[SerializeField]
	//[Range(50,500)]
	//float m_angularSpeed = 300;

	[SerializeField]
	[Range(10,50)]
	float m_impulseMagnitude = 25;

    float speed;

    

	

	[Header("Affected Rigidbody Properties")]
	[SerializeField] GrabObjectProperties m_grabProperties = new GrabObjectProperties();	

	GrabObjectProperties m_defaultProperties = new GrabObjectProperties();

	[Header("Layers")]
	[SerializeField]
	public LayerMask collisionMask;

	

	Rigidbody m_targetRB = null;
	Transform m_transform;	

	Vector3 m_targetPos;
	GameObject m_hitPointObject;
	float m_targetDistance;

	bool m_grabbing = false;
	bool m_applyImpulse = false;
	bool m_isHingeJoint = false;




	void Awake()
	{
		m_transform = transform;
		m_hitPointObject = new GameObject("Point");
	}

	
	void Update()
	{
		if( m_grabbing )
		{
			m_targetDistance = 2;

			m_targetPos = m_transform.position + m_transform.forward * m_targetDistance;

            
						
			if(!m_isHingeJoint)
            {               
					m_targetRB.constraints = m_grabProperties.m_constraints;
			}
			

			if( Input.GetMouseButtonUp(0) ){				
				Reset();
				m_grabbing = false;
			}else if ( Input.GetMouseButtonDown(1) )
            {
				m_applyImpulse = true;

			}

			
		}
		else
		{

			if(Input.GetMouseButtonDown(0))
			{
				RaycastHit hitInfo;
				if(Physics.Raycast(m_transform.position , m_transform.forward , out hitInfo , m_grabMaxDistance , collisionMask ))
				{
					Rigidbody rb = hitInfo.collider.GetComponent<Rigidbody>();
					if(rb != null){							
						Set( rb , hitInfo.distance);						
						m_grabbing = true;
					}
				}
			}
		}


		
	}
	
	void Set(Rigidbody target , float distance)
	{	
        
		m_targetRB = target;
		m_isHingeJoint = target.GetComponent<HingeJoint>() != null;

		//Rigidbody default properties	
		m_defaultProperties.m_useGravity = m_targetRB.useGravity;	
		m_defaultProperties.m_drag = m_targetRB.drag;
		m_defaultProperties.m_angularDrag = m_targetRB.angularDrag;
		m_defaultProperties.m_constraints = m_targetRB.constraints;

		//Grab Properties	
		m_targetRB.useGravity = m_grabProperties.m_useGravity;
		m_targetRB.drag = m_grabProperties.m_drag;
		m_targetRB.angularDrag = m_grabProperties.m_angularDrag;
		
		
		m_hitPointObject.transform.SetParent(target.transform);							

		m_targetDistance = distance;
		m_targetPos = m_transform.position + m_transform.forward * m_targetDistance;

		m_hitPointObject.transform.position = m_targetPos;
		m_hitPointObject.transform.LookAt(m_targetPos);
				
	}

	void Reset()
	{		
		//Grab Properties	
		m_targetRB.useGravity = m_defaultProperties.m_useGravity;
		m_targetRB.drag = m_defaultProperties.m_drag;
		m_targetRB.angularDrag = m_defaultProperties.m_angularDrag;
		
		m_targetRB = null;

		m_hitPointObject.transform.SetParent(null);
	}

	void Grab()
	{
		Vector3 hitPointPos = m_hitPointObject.transform.position;
		Vector3 dif = m_targetPos - hitPointPos;

        m_targetRB.freezeRotation = true; 

		if(m_isHingeJoint)
			m_targetRB.AddForceAtPosition( m_grabSpeed  * dif * 100 , hitPointPos , ForceMode.Force);
		else
			m_targetRB.velocity = m_grabSpeed * dif;		
	}
	
	void FixedUpdate()
	{
		if(!m_grabbing)
			return;
        
		Grab();		

		if(m_applyImpulse)
        {
            m_targetRB.velocity = m_transform.forward * m_impulseMagnitude;
            m_targetRB.freezeRotation = false;

            float random = Random.Range(-1f, 1f);
                m_targetRB.AddTorque(new Vector3(random, random, random) * 15);

            Reset();
            m_grabbing = false;
            m_applyImpulse = false;
        }		
	}

}

}
