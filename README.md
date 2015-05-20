# Classical-Music-Schema

Project to create a proof-of-concept API which aims to better supports the complex metadata schema of classical music. 

Built on top of a neo4j Graph database - the repo containing the metadata sample used and Cypher import script can be found here (accessible only within the 7digital organisation): https://github.com/7digital/Classical-Music-Data-Import

The API currently only has a ~/status and a ~/release/{id} endpoint; next planned steps are:

1. Extend the information returned by the ~/release/{id} endpoint to include recording, conductor and ensemble information.

2. Add ~/conductor/{id}/releases and ~/ensemble/{id}/releases endpoints, with links both ways between these and the ~/release/{id} endpoint.
