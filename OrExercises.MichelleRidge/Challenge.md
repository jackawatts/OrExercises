Michelle Ridge Jewelry specialize in the creation of wedding bands for that special occasion.

Unfortunately isolation and quarantine measures by the government due to COVID-19 reduced the demand on wedding rings and their business model suffered as a result.

Unable to procure new materials, Michelle Ridge Jewelry need to utilize their remaining raw materials as best as they can:

Their range of bands, the number of mg of raw material required to manufacture each band and the total stores of raw material available (Availability in kg) is shown in the table below:

| Band         | Gold     | Silver  | Copper  | Platinum | Zinc
|--------------|----------|---------|---------|----------|-------
| Rose Gold    | 7500mg   |  275mg  |  2225mg |          |        
| White Gold   | 7500mg   |         |         | 2500mg   |     
| Yellow Gold  | 9167mg   |  500mg  |   200mg |          |  133mg
| Green Gold   | 7500mg   | 2000mg  |   500mg |          |       
| Availability | 30kg     |  2.5kg  | 2.5kg   | 2kg      |  0.1kg

Michelle Ridge Jewelry want to know how many bands of each type up to a maximum of 1000 of each they can manufacture with the material they have available.

Note:
Rings are small, but availability of raw material is large:
* 1000 mg = 1g
* 1000 g = 1kg

# Questions around defining optimization problems:

1. Identify the question to answer. This identification should take the form of a precise sentence involving either counting or valuating one or more objects.

2. Identify all requirements and translate them into constraints. It is often best to write down each requirement in a precise sentence before translating it into a constraint. It is important to differentiate between equal to and at_most. (The satisfycing metrics). A constraint needs to be expressed as an algebraic equality or inequality.

3. Identify the objective to optimize. The objective is, in the case of an optimization problem, what we want to maximize (or minimize). In the case of a feasibility problem, there is no objective, but in practice, most feasibility problems are really optimization problems that have been incompletely formulated. (The optimizing metric). The objective needs to be able to be expressed as an algebraic expression that needs to be maximised or minimised.

# For Linear Programs:
The **objective function** takes takes the format:

c<sub>1</sub>x<sub>1</sub> + c<sub>2</sub> x<sub>2</sub> + c<sub>3</sub>x<sub>3</sub> + ...c<sub>n</sub>x<sub>n</sub>

**Constraints** are parameterized by matrix a<sub>ij</sub>, array b, and can be stated as a set of relations

a<sub>i1</sub>x<sub>i1</sub> + a<sub>i2</sub> x<sub>i2</sub> + ...a<sub>in</sub>x<sub>in</sub> <= | = | >= b<sub>i</sub>